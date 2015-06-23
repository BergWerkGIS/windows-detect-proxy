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


		private string _TargetUrl;
		private Uri _TargetUri;


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

			IDC_lvInfo.Items.Clear();
			IDC_tbDefaultWebProxy.Text = string.Empty;
			IDC_tbSystemWebProxy.Text = string.Empty;
			IDC_tbRegistry.Text = string.Empty;
			IDC_tbHttpWebRequest.Text = string.Empty;

			try {
				Cursor = Cursors.WaitCursor;
				webRequestDefaultWebProxy();
				webRequestGetSystemWebProxy();
				httpWebRequest();
				readRegistry();
			}
			finally {
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
					log( "no proxy" );
					IDC_tbDefaultWebProxy.Text = string.Empty;
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
					log( "no proxy" );
					IDC_tbSystemWebProxy.Text = string.Empty;
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
				Uri proxyUri=proxy.GetProxy(_TargetUri);
				string proxyUrl = proxyUri.AbsoluteUri;
				if (proxyUrl.Equals( _TargetUrl, StringComparison.OrdinalIgnoreCase )) {
					log( "no proxy" );
					IDC_tbHttpWebRequest.Text = string.Empty;
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

				WebProxy proxy = null;
				IDC_tbRegistry.Text = string.Empty;

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
							log( "no proxy" );
						} else {
							log( "proxy enabled via registry" );
							object objProxy = iSettings.GetValue( "ProxyServer" );
							if (null == objProxy) {
								log( "no proxy set", true );
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

			try {
				using (WebClient wc = new WebClient()) {
					wc.Proxy = proxy;
					log( "connecting ..." );
					try {
						log( "response: " + wc.DownloadString( _TargetUri ) );
					}
					catch (Exception ex2) {
						log( "response: " + ex2.ToString(), true );
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
