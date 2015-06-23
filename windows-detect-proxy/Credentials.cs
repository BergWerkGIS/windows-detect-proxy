using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace windows_detect_proxy {
	public partial class Credentials : Form {
		public Credentials() {
			InitializeComponent();
		}


		public string User {
			get { return IDC_tbUser.Text; }
		}

		public string Pwd {
			get { return IDC_tbPwd.Text; }
		}


		private void IDC_bOk_Click( object sender, EventArgs e ) {

			if (string.IsNullOrWhiteSpace( IDC_tbUser.Text )) {
				MessageBox.Show( "user empty", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
				return;
			}

			if (string.IsNullOrWhiteSpace( IDC_tbPwd.Text )) {
				MessageBox.Show( "password empty", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
				return;
			}

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void IDC_bCancel_Click( object sender, EventArgs e ) {
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}





	}
}
