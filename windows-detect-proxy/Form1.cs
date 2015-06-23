using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;


namespace windows_detect_proxy {


	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}


		private bool _NTLMDetected = false;
		private bool _CustomCreds = false;
		private string _TargetUrl;
		private Uri _TargetUri;
		private readonly string NO_PROXY = "no proxy";


		private void IDC_eExit_Click( object sender, EventArgs e ) {
			this.Close();
		}


		private void IDC_bDetect_Click( object sender, EventArgs e ) {

			if (string.IsNullOrWhiteSpace( IDC_tbUrl.Text )) {
				MessageBox.Show( "no target URL", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
				return;
			}
			_TargetUrl = IDC_tbUrl.Text;
			if (!_TargetUrl.EndsWith( "/" )) { _TargetUrl += "/"; }
			_TargetUri = new Uri( _TargetUrl );

			WebRequest.DefaultWebProxy.Credentials = new NetworkCredential();
			_NTLMDetected = false;
			_CustomCreds = false;
			IDC_lvInfo.Items.Clear();
			IDC_tbDefaultWebProxy.Text = string.Empty;
			IDC_tbSystemWebProxy.Text = string.Empty;
			IDC_tbRegistry.Text = string.Empty;
			IDC_tbHttpWebRequest.Text = string.Empty;
			IDC_tbNTLM.Text = "no NTLM detected";
			IDC_tbCustomCreds.Text = string.Empty;

			try {
				Cursor = Cursors.WaitCursor;
				webRequestDefaultWebProxy();
				webRequestGetSystemWebProxy();
				httpWebRequest();
				readRegistry();
			}
			finally {
				if (_NTLMDetected) {
					IDC_tbNTLM.Text = "NTLM detected: user your windows login credentials as proxy credentials";
				}
				if (_CustomCreds) {
					IDC_tbCustomCreds.Text = "use your custom credentials as proxy credentials";
				}
				Cursor = Cursors.Default;
			}
		}



		private void webRequestDefaultWebProxy() {

			try {
				log( "== testing WebRequest.DefaultWebProxy ==" );
				IWebProxy proxy = WebRequest.DefaultWebProxy;
				//TODO: how to get credentials???
				Uri proxyUri = proxy.GetProxy( _TargetUri );
				string proxyUrl = proxyUri.AbsoluteUri;
				if (proxyUrl.Equals( _TargetUrl, StringComparison.OrdinalIgnoreCase )) {
					log( NO_PROXY );
					IDC_tbDefaultWebProxy.Text = NO_PROXY;
				} else {
					log( proxyUrl );
					IDC_tbDefaultWebProxy.Text = proxyUrl;
				}
				testRequest( proxy );
			}
			catch (Exception ex) {
				log( ex.ToString(), true );
			}
		}

		private void webRequestGetSystemWebProxy() {

			try {
				log( "== testing WebRequest.GetSystemWebProxy ==" );
				IWebProxy proxy = WebRequest.GetSystemWebProxy();
				Uri proxyUri = proxy.GetProxy( _TargetUri );
				string proxyUrl = proxyUri.AbsoluteUri;
				if (proxyUrl.Equals( _TargetUrl, StringComparison.OrdinalIgnoreCase )) {
					log( NO_PROXY );
					IDC_tbSystemWebProxy.Text = NO_PROXY;
				} else {
					log( proxyUrl );
					IDC_tbSystemWebProxy.Text = proxyUrl;
				}
				testRequest( proxy );
			}
			catch (Exception ex) {
				log( ex.ToString(), true );
			}
		}


		private void httpWebRequest() {

			try {
				log( "== testing HttpWebRequest ==" );

				HttpWebRequest request = (HttpWebRequest)WebRequest.Create( _TargetUri );
				IWebProxy proxy = request.Proxy;
				Uri proxyUri = proxy.GetProxy( _TargetUri );
				string proxyUrl = proxyUri.AbsoluteUri;
				if (proxyUrl.Equals( _TargetUrl, StringComparison.OrdinalIgnoreCase )) {
					log( NO_PROXY );
					IDC_tbHttpWebRequest.Text = NO_PROXY;
				} else {
					log( proxyUrl );
					IDC_tbHttpWebRequest.Text = proxyUrl;
				}
				testRequest( proxy );
			}
			catch (Exception ex) {
				log( ex.ToString(), true );
			}
		}

		private void readRegistry() {

			try {
				log( "== testing registry settings ==" );


				//TODO
				//http://stackoverflow.com/a/9142909

				WebProxy proxy = null;
				IDC_tbRegistry.Text = NO_PROXY;

				RegistryKey iSettings = Registry.
					CurrentUser.
					OpenSubKey( @"Software\Microsoft\Windows\CurrentVersion\Internet Settings" );

				if (null == iSettings) {
					log( "could not open registry key 'Internet Settings'", true );
				} else {
					object objEnable = iSettings.GetValue( "ProxyEnable" );
					if (null == objEnable) {
						log( "could not get value for registry key 'ProxyEnable'" );
					} else {
						int proxyEnable = Convert.ToInt32( objEnable );
						if (0 == proxyEnable) {
							log( NO_PROXY );
						} else {
							log( "proxy enabled via registry" );
							object objProxy = iSettings.GetValue( "ProxyServer" );
							if (null == objProxy) {
								log( "proxy enabled, but no proxy set", true );
							} else {
								string proxyUrl = objProxy.ToString();
								log( proxyUrl );
								IDC_tbRegistry.Text = proxyUrl;
								//TODO parse responce
								//proxy = new WebProxy( proxyUrl, true );
							}
						}
					}
				}

				//testRequest( proxy );
			}
			catch (Exception ex) {
				log( ex.Message, true );
			}

		}


		private void testRequest( IWebProxy proxy ) {

			//authentication
			//Working With Proxy Servers Get Your Internet App's Working With Them
			//http://www.dreamincode.net/forums/topic/160555-working-with-proxy-servers/
			try {
				using (WebClient wc = new WebClient()) {
					wc.UseDefaultCredentials = false;
					proxy.Credentials = null;
					wc.Proxy = proxy;
					log( "connecting ..." );
					try {
						log( "response: " + wc.DownloadString( _TargetUri ) );
						return;
					}
					catch (WebException wex) {
						if (HttpStatusCode.ProxyAuthenticationRequired == ((HttpWebResponse)wex.Response).StatusCode) {
							log( "authentication required" );
						} else {
							log( "response: " + wex.ToString(), true );
							return;
						}
					}
					catch (Exception ex2) {
						log( "response: " + ex2.ToString(), true );
						return;
					}
				}

				log( "checking for NTLM authentication" );
				//WebRequest.DefaultWebProxy.Credentials = CredentialCache.DefaultCredentials;
				using (WebClient wc = new WebClient()) {
					wc.UseDefaultCredentials = true;
					proxy.Credentials = CredentialCache.DefaultCredentials;
					wc.Proxy = proxy;
					try {
						log( "response: " + wc.DownloadString( _TargetUrl ) );
						log( "NTLM authentication in place - use your Windows credentials when settings proxy user and password!!!", true );
						_NTLMDetected = true;
						return;
					}
					catch (WebException wex) {
						if (HttpStatusCode.ProxyAuthenticationRequired == ((HttpWebResponse)wex.Response).StatusCode) {
							log( "NTLM authentication failed", true );
						} else {
							log( "response: " + wex.ToString(), true );
							return;
						}
					}
					catch (Exception ex2) {
						log( "response: " + ex2.ToString(), true );
						return;
					}
				}

				log( "checking for custom crededentials" );
				string user;
				string pwd;
				using (Credentials creds = new Credentials()) {
					if (DialogResult.Cancel == creds.ShowDialog()) {
						log( "did not enter custom credentials", true );
						return;
					}
					user = creds.User;
					pwd = creds.Pwd;
				}

				using (WebClient wc = new WebClient()) {
					wc.UseDefaultCredentials = false;
					proxy.Credentials = new NetworkCredential( user, pwd );
					wc.Proxy = proxy;
					try {
						log( "response: " + wc.DownloadString( _TargetUrl ) );
						log( "custom credentials successful" );
						_CustomCreds = true;
						return;
					}
					catch (WebException wex) {
						if (HttpStatusCode.ProxyAuthenticationRequired == ((HttpWebResponse)wex.Response).StatusCode) {
							log( "custom credentials authentication failed", true );
						} else {
							log( "response: " + wex.ToString(), true );
							return;
						}
					}
					catch (Exception ex2) {
						log( "response: " + ex2.ToString(), true );
						return;
					}
				}
			}
			catch (Exception ex) {
				log( ex.ToString(), true );
			}
		}


		private void log( string msg, bool isError = false ) {

			ListViewItem lvi = new ListViewItem( msg );
			if (isError) {
				lvi.BackColor = Color.OrangeRed;
			}
			IDC_lvInfo.Items.Add( lvi );
		}

		private void IDC_bCopyInfo_Click( object sender, EventArgs e ) {
			MessageBox.Show( "not implemented" );
		}


	}
}
