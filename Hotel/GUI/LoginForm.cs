using BUS;
using DTO.Domain;
using System;
using System.Windows.Forms;

namespace GUI
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
			this.FormClosed += new FormClosedEventHandler(Form_FormClosed);
		}

		private void FormLogin_Load(object sender, EventArgs e)
		{
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			txtId.Text = "1";
			txtPassword.Text = "1";
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			//Kiểm tra thông tin
			if (string.IsNullOrEmpty(txtId.Text.Trim()) || string.IsNullOrEmpty(txtPassword.Text.Trim()))
			{
				MessageBox.Show("Vui lòng kiểm tra lại thông tin đăng nhập và mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Employee employee = new Employee()
			{
				EmployeeId = txtId.Text,
				Password = txtPassword.Text
			};
			try
			{
				if (!EmployeeBUS.IsValid(employee))
				{
					MessageBox.Show("Thông tin đăng nhập hoặc mật khẩu không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Không thể kết nối cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Dispose();
				return;
			}
			//this.Hide();
		}

		private void Enter_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				btnLogin_Click(sender, e);
		}

		private void Form_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void btnConfig_Click(object sender, EventArgs e)
		{
			new ConfigForm().Show();
		}
	}
}
