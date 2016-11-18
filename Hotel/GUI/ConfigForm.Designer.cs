namespace GUI
{
	partial class ConfigForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.checkBoxWindows = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtServerName = new System.Windows.Forms.TextBox();
			this.txtDatabaseName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnConnect = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// checkBoxWindows
			// 
			this.checkBoxWindows.AutoSize = true;
			this.checkBoxWindows.Location = new System.Drawing.Point(24, 24);
			this.checkBoxWindows.Name = "checkBoxWindows";
			this.checkBoxWindows.Size = new System.Drawing.Size(180, 21);
			this.checkBoxWindows.TabIndex = 0;
			this.checkBoxWindows.Text = "Windows Authentication";
			this.checkBoxWindows.UseVisualStyleBackColor = true;
			this.checkBoxWindows.CheckedChanged += new System.EventHandler(this.chkWAuthentication_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "Server name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "Database name:";
			// 
			// txtServerName
			// 
			this.txtServerName.Location = new System.Drawing.Point(187, 69);
			this.txtServerName.Name = "txtServerName";
			this.txtServerName.Size = new System.Drawing.Size(206, 22);
			this.txtServerName.TabIndex = 0;
			// 
			// txtDatabaseName
			// 
			this.txtDatabaseName.Location = new System.Drawing.Point(187, 97);
			this.txtDatabaseName.Name = "txtDatabaseName";
			this.txtDatabaseName.Size = new System.Drawing.Size(206, 22);
			this.txtDatabaseName.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(92, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(216, 29);
			this.label3.TabIndex = 4;
			this.label3.Text = "Connect to Server";
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(290, 257);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(103, 23);
			this.btnConnect.TabIndex = 3;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(225, 76);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(128, 22);
			this.txtPassword.TabIndex = 4;
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(225, 48);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(128, 22);
			this.txtUserName.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(24, 76);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 17);
			this.label4.TabIndex = 2;
			this.label4.Text = "Password:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(24, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 17);
			this.label5.TabIndex = 1;
			this.label5.Text = "User name:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBoxWindows);
			this.groupBox1.Controls.Add(this.txtPassword);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtUserName);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Location = new System.Drawing.Point(15, 137);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(378, 114);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Log on to the server";
			// 
			// FormConfig
			// 
			this.AcceptButton = this.btnConnect;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(405, 291);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtDatabaseName);
			this.Controls.Add(this.txtServerName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.Name = "FormConfig";
			this.Text = "Connec to Server";
			this.Load += new System.EventHandler(this.FormConfig_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox checkBoxWindows;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtServerName;
		private System.Windows.Forms.TextBox txtDatabaseName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}

