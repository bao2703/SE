using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BUS;
using DTO;

namespace GUI
{
	/// <summary>
	/// Interaction logic for ConfigWindow.xaml
	/// </summary>
	public partial class ConfigWindow : Window
	{
		public ConfigWindow()
		{
			InitializeComponent();
		}

		private void btnConnect_Click(object sender, RoutedEventArgs e)
		{
			var config = new Config()
			{
				ServerName = txtServerName.Text,
				DatabaseName = txtDatabaseName.Text,
				UserName = txtUserName.Text,
				Password = txtPassword.Text
			};
			if (checkBoxWindows.IsChecked == true)
			{
				ConfigBUS.WindowsAuthentication(config);
			}
			else
			{
				ConfigBUS.SQLSeverAuthentication(config);
			}
			this.Close();
		}

		private void checkBoxWindows_Click(object sender, RoutedEventArgs e)
		{
			if (checkBoxWindows.IsChecked == true)
			{
				txtUserName.IsEnabled = false;
				txtPassword.IsEnabled = false;
			}
			else
			{
				txtUserName.IsEnabled = true;
				txtPassword.IsEnabled = true;
			}
		}
	}
}
