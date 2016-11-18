using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO.Domain;
using DTO;

namespace GUI
{
	public partial class ConfigForm : Form
	{
		public ConfigForm()
		{
			InitializeComponent();
		}
		private void btnConnect_Click(object sender, EventArgs e)
		{
			var config = new Config()
			{
				ServerName = txtServerName.Text,
				DatabaseName = txtDatabaseName.Text,
				UserName = txtUserName.Text,
				Password = txtPassword.Text
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
			txtUserName.Enabled = txtUserName.Enabled ^ true;
			txtPassword.Enabled = txtPassword.Enabled ^ true;
		}

		private void FormConfig_Load(object sender, EventArgs e)
		{
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
		}
	}
}
