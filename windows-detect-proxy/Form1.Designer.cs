namespace windows_detect_proxy {
	partial class Form1 {
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
			this.IDC_tbUrl = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.IDC_bDetect = new System.Windows.Forms.Button();
			this.IDC_lvInfo = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.IDC_eExit = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.IDC_tbHttpWebRequest = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.IDC_tbRegistry = new System.Windows.Forms.TextBox();
			this.IDC_tbSystemWebProxy = new System.Windows.Forms.TextBox();
			this.IDC_tbDefaultWebProxy = new System.Windows.Forms.TextBox();
			this.IDC_tbNTLM = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.IDC_tbCustomCreds = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// IDC_tbUrl
			// 
			this.IDC_tbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.IDC_tbUrl.Location = new System.Drawing.Point(12, 25);
			this.IDC_tbUrl.Name = "IDC_tbUrl";
			this.IDC_tbUrl.Size = new System.Drawing.Size(557, 20);
			this.IDC_tbUrl.TabIndex = 0;
			this.IDC_tbUrl.Text = "https://a.tiles.mapbox.com/";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Target URL";
			// 
			// IDC_bDetect
			// 
			this.IDC_bDetect.Location = new System.Drawing.Point(12, 51);
			this.IDC_bDetect.Name = "IDC_bDetect";
			this.IDC_bDetect.Size = new System.Drawing.Size(134, 23);
			this.IDC_bDetect.TabIndex = 2;
			this.IDC_bDetect.Text = "detect";
			this.IDC_bDetect.UseVisualStyleBackColor = true;
			this.IDC_bDetect.Click += new System.EventHandler(this.IDC_bDetect_Click);
			// 
			// IDC_lvInfo
			// 
			this.IDC_lvInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.IDC_lvInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.IDC_lvInfo.Location = new System.Drawing.Point(12, 318);
			this.IDC_lvInfo.Name = "IDC_lvInfo";
			this.IDC_lvInfo.Size = new System.Drawing.Size(557, 106);
			this.IDC_lvInfo.TabIndex = 3;
			this.IDC_lvInfo.UseCompatibleStateImageBehavior = false;
			this.IDC_lvInfo.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Info";
			this.columnHeader1.Width = 500;
			// 
			// IDC_eExit
			// 
			this.IDC_eExit.Location = new System.Drawing.Point(152, 51);
			this.IDC_eExit.Name = "IDC_eExit";
			this.IDC_eExit.Size = new System.Drawing.Size(75, 23);
			this.IDC_eExit.TabIndex = 4;
			this.IDC_eExit.Text = "exit";
			this.IDC_eExit.UseVisualStyleBackColor = true;
			this.IDC_eExit.Click += new System.EventHandler(this.IDC_eExit_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.IDC_tbCustomCreds);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.IDC_tbNTLM);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.IDC_tbHttpWebRequest);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.IDC_tbRegistry);
			this.groupBox1.Controls.Add(this.IDC_tbSystemWebProxy);
			this.groupBox1.Controls.Add(this.IDC_tbDefaultWebProxy);
			this.groupBox1.Location = new System.Drawing.Point(12, 93);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(557, 190);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = " detexted proxy settings ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 115);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "HttpWebRequest";
			// 
			// IDC_tbHttpWebRequest
			// 
			this.IDC_tbHttpWebRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.IDC_tbHttpWebRequest.Location = new System.Drawing.Point(129, 112);
			this.IDC_tbHttpWebRequest.Name = "IDC_tbHttpWebRequest";
			this.IDC_tbHttpWebRequest.Size = new System.Drawing.Size(422, 20);
			this.IDC_tbHttpWebRequest.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 37);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 13);
			this.label4.TabIndex = 15;
			this.label4.Text = "DefaultWebProxy";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "SystemWebProxy";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Registry";
			// 
			// IDC_tbRegistry
			// 
			this.IDC_tbRegistry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.IDC_tbRegistry.Location = new System.Drawing.Point(129, 86);
			this.IDC_tbRegistry.Name = "IDC_tbRegistry";
			this.IDC_tbRegistry.Size = new System.Drawing.Size(422, 20);
			this.IDC_tbRegistry.TabIndex = 12;
			// 
			// IDC_tbSystemWebProxy
			// 
			this.IDC_tbSystemWebProxy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.IDC_tbSystemWebProxy.Location = new System.Drawing.Point(129, 60);
			this.IDC_tbSystemWebProxy.Name = "IDC_tbSystemWebProxy";
			this.IDC_tbSystemWebProxy.Size = new System.Drawing.Size(422, 20);
			this.IDC_tbSystemWebProxy.TabIndex = 11;
			// 
			// IDC_tbDefaultWebProxy
			// 
			this.IDC_tbDefaultWebProxy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.IDC_tbDefaultWebProxy.Location = new System.Drawing.Point(129, 34);
			this.IDC_tbDefaultWebProxy.Name = "IDC_tbDefaultWebProxy";
			this.IDC_tbDefaultWebProxy.Size = new System.Drawing.Size(422, 20);
			this.IDC_tbDefaultWebProxy.TabIndex = 10;
			// 
			// IDC_tbNTLM
			// 
			this.IDC_tbNTLM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.IDC_tbNTLM.Location = new System.Drawing.Point(129, 138);
			this.IDC_tbNTLM.Name = "IDC_tbNTLM";
			this.IDC_tbNTLM.ReadOnly = true;
			this.IDC_tbNTLM.Size = new System.Drawing.Size(422, 20);
			this.IDC_tbNTLM.TabIndex = 16;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 141);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(37, 13);
			this.label6.TabIndex = 17;
			this.label6.Text = "NTLM";
			// 
			// IDC_tbCustomCreds
			// 
			this.IDC_tbCustomCreds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.IDC_tbCustomCreds.Location = new System.Drawing.Point(129, 164);
			this.IDC_tbCustomCreds.Name = "IDC_tbCustomCreds";
			this.IDC_tbCustomCreds.ReadOnly = true;
			this.IDC_tbCustomCreds.Size = new System.Drawing.Size(422, 20);
			this.IDC_tbCustomCreds.TabIndex = 18;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(8, 167);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 13);
			this.label7.TabIndex = 19;
			this.label7.Text = "Custom credentials";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(581, 436);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.IDC_eExit);
			this.Controls.Add(this.IDC_lvInfo);
			this.Controls.Add(this.IDC_bDetect);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.IDC_tbUrl);
			this.Name = "Form1";
			this.Text = "detect proxy";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox IDC_tbUrl;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button IDC_bDetect;
		private System.Windows.Forms.ListView IDC_lvInfo;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.Button IDC_eExit;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox IDC_tbRegistry;
		private System.Windows.Forms.TextBox IDC_tbSystemWebProxy;
		private System.Windows.Forms.TextBox IDC_tbDefaultWebProxy;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox IDC_tbHttpWebRequest;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox IDC_tbNTLM;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox IDC_tbCustomCreds;
	}
}

