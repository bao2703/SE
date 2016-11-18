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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BUS;
using DTO.Domain;

namespace GUI
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class LoginWindow : Window
	{
		public LoginWindow()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, RoutedEventArgs e)
		{
			Employee employee = new Employee()
			{
				EmployeeId = txtUserName.Text,
				Password = txtPassword.Password
			};
			try
			{
				if (!EmployeeBUS.IsValid(employee))
				{
					MessageBox.Show("Thông tin đăng nhập hoặc mật khẩu không hợp lệ.", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Warning);
					return;
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Không thể kết nối cơ sở dữ liệu.", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Warning);
			}
			this.Hide();
			new MainWindow().Show();
		}

		private void btnConfig_Click(object sender, RoutedEventArgs e)
		{
			new ConfigWindow().Show();
		}
	}
}
