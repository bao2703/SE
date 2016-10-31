using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
	public partial class FormConfig : Form
	{
		public FormConfig()
		{
			InitializeComponent();
		}
		private void btnConnect_Click(object sender, EventArgs e)
		{
			if (chkWAuthentication.Checked == true)
			{
				ConfigBUS.WindowsAuthentication(
					new Config(txtServerName.Text, txtDatabaseName.Text, true));
			}
			else
			{
				ConfigBUS.SQLSeverAuthentication(
					new Config(txtServerName.Text, txtDatabaseName.Text, false, txtUserName.Text, txtPassword.Text));
			}
			this.Dispose();
		}

		private void chkWAuthentication_CheckedChanged(object sender, EventArgs e)
		{
			txtUserName.Enabled = txtUserName.Enabled ^ true;
			txtPassword.Enabled = txtPassword.Enabled ^ true;
		}

		private void FormConfig_Load(object sender, EventArgs e)
		{
			Config config = ConfigBUS.GetAppConfig();
			txtServerName.Text = config.ServerName;
			txtDatabaseName.Text = config.DatabaseName;
			chkWAuthentication.Checked = config.WindowsAuthentication;
			txtUserName.Text = config.Username;
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
		}

		private void Enter_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				btnConnect_Click(sender, e);
		}
	}
}
