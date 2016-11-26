namespace GUI
{
	using System;
	using System.Windows.Forms;
	using BUS;
	using DTO;

	public partial class ConfigForm : Form
	{
		public ConfigForm()
		{
			this.InitializeComponent();
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			var config = new Config()
			{
				ServerName = this.txtServerName.Text,
				DatabaseName = this.txtDatabaseName.Text,
				UserName = this.txtUserName.Text,
				Password = this.txtPassword.Text
			};
			if (checkBoxWindows.Checked == true)
			{
				ConfigBUS.WindowsAuthentication(config);
			}
			else
			{
				ConfigBUS.SQLSeverAuthentication(config);
			}
			this.Dispose();
		}

		private void chkWAuthentication_CheckedChanged(object sender, EventArgs e)
		{
			this.txtUserName.Enabled = this.txtUserName.Enabled ^ true;
			this.txtPassword.Enabled = this.txtPassword.Enabled ^ true;
		}

		private void FormConfig_Load(object sender, EventArgs e)
		{
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
		}
	}
}
