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
using DTO;

namespace GUI
{
	public partial class FormMain : Form
	{
		private NhanVien nhanVien;
		private List<ChiTietDatPhong> chiTietDatPhong;

		public FormMain(NhanVien nhanVien)
		{
			InitializeComponent();
			this.nhanVien = nhanVien;
			lblTenNhanVien.Text = nhanVien.Ten;
			this.FormClosed += new FormClosedEventHandler(Form_FormClosed);
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			this.Dispose();
			new FormLogin().Show();
		}
		private void Form_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void btnXacNhan_Click(object sender, EventArgs e)
		{
			KhachHang khachHang = new KhachHang(KhachHangBUS.NextId(), txtHoTen.Text, txtDiaChi.Text, txtSoDienThoai.Text, txtFax.Text, txtTelex.Text);
			KhachHangBUS.Add(khachHang);
			// need add some method to make defaut chiTietDatPhong
			if (chiTietDatPhong == null)
			{
				//chiTietDatPhong
			}
			PhieuDatPhong phieuDatPhong = new PhieuDatPhong(PhieuDatPhongBUS.NextId(), khachHang, nhanVien, DateTime.Now, 100, 100, chiTietDatPhong);
			PhieuDatPhongBUS.Add(phieuDatPhong);
		}

		private void btnChiTiet_Click(object sender, EventArgs e)
		{
			new FormChiTietDatPhong(chiTietDatPhong).Show();
		}
	}
}
