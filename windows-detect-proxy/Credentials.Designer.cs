namespace windows_detect_proxy {
	partial class Credentials {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.IDC_bCancel = new System.Windows.Forms.Button();
			this.IDC_bOk = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.IDC_tbUser = new System.Windows.Forms.TextBox();
			this.IDC_tbPwd = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// IDC_bCancel
			// 
			this.IDC_bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.IDC_bCancel.Location = new System.Drawing.Point(205, 184);
			this.IDC_bCancel.Name = "IDC_bCancel";
			this.IDC_bCancel.Size = new System.Drawing.Size(75, 23);
			this.IDC_bCancel.TabIndex = 0;
			this.IDC_bCancel.Text = "Cancel";
			this.IDC_bCancel.UseVisualStyleBackColor = true;
			this.IDC_bCancel.Click += new System.EventHandler(this.IDC_bCancel_Click);
			// 
			// IDC_bOk
			// 
			this.IDC_bOk.Location = new System.Drawing.Point(12, 184);
			this.IDC_bOk.Name = "IDC_bOk";
			this.IDC_bOk.Size = new System.Drawing.Size(75, 23);
			this.IDC_bOk.TabIndex = 1;
			this.IDC_bOk.Text = "OK";
			this.IDC_bOk.UseVisualStyleBackColor = true;
			this.IDC_bOk.Click += new System.EventHandler(this.IDC_bOk_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Password";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "User name";
			// 
			// IDC_tbUser
			// 
			this.IDC_tbUser.Location = new System.Drawing.Point(7, 45);
			this.IDC_tbUser.Name = "IDC_tbUser";
			this.IDC_tbUser.Size = new System.Drawing.Size(255, 20);
			this.IDC_tbUser.TabIndex = 4;
			// 
			// IDC_tbPwd
			// 
			this.IDC_tbPwd.Location = new System.Drawing.Point(7, 95);
			this.IDC_tbPwd.Name = "IDC_tbPwd";
			this.IDC_tbPwd.PasswordChar = '*';
			this.IDC_tbPwd.Size = new System.Drawing.Size(255, 20);
			this.IDC_tbPwd.TabIndex = 5;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.IDC_tbPwd);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.IDC_tbUser);
			this.groupBox1.Location = new System.Drawing.Point(12, 25);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(268, 135);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = " enter your proxy credentials ";
			// 
			// Credentials
			// 
			this.AcceptButton = this.IDC_bOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.IDC_bCancel;
			this.ClientSize = new System.Drawing.Size(292, 219);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.IDC_bOk);
			this.Controls.Add(this.IDC_bCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Credentials";
			this.Text = "enter you credentials";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button IDC_bCancel;
		private System.Windows.Forms.Button IDC_bOk;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox IDC_tbUser;
		private System.Windows.Forms.TextBox IDC_tbPwd;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}