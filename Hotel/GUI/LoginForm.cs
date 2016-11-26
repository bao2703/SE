namespace GUI
{
	using System;
	using System.Windows.Forms;
	using BUS;
	using DTO;

	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			this.InitializeComponent();
			this.FormClosed += new FormClosedEventHandler(this.Form_FormClosed);
		}

		private void FormLogin_Load(object sender, EventArgs e)
		{
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.txtId.Text = "1";
			this.txtPassword.Text = "1";
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtId.Text.Trim()) || string.IsNullOrEmpty(txtPassword.Text.Trim()))
			{
				MessageBox.Show("Vui lòng kiểm tra lại thông tin đăng nhập và mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			EmployeeDTO employee = new EmployeeDTO()
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
			new MainForm(employee).Show();
			//this.Hide();
		}

		private void Enter_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.btnLogin_Click(sender, e);
			}
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
