using System;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
	public partial class FormLogin : Form
	{
		FormConfig formConfig;
		public FormLogin(FormConfig formConfig)
		{
			InitializeComponent();
			this.formConfig = formConfig;
		}
		public FormLogin()
		{
			InitializeComponent();
			this.FormClosed += new FormClosedEventHandler(Form_FormClosed);
		}

		private void FormLogin_Load(object sender, EventArgs e)
		{
			this.CenterToScreen();
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
			NhanVien nhanVien = new NhanVien(txtId.Text, txtPassword.Text);
			try
			{
				if (!NhanVienBUS.IsValid(nhanVien))
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
			new FormMain(NhanVienBUS.Get(nhanVien.Id)).Show();
			if (formConfig != null)
			{
				formConfig.Hide();
			}
			this.Dispose();
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
	}
}
