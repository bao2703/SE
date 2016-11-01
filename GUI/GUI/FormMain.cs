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
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox1.Items.AddRange(new object[] { "Tất cả", LoaiPhong.A, LoaiPhong.B, LoaiPhong.C, LoaiPhong.D });
			comboBox1.SelectedIndex = 0;
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
			PhieuDatPhong phieuDatPhong = new PhieuDatPhong(PhieuDatPhongBUS.NextId(), khachHang, nhanVien, DateTime.Now,
				dateTimeNgayDen.Value, dateTimeNgayDi.Value, chiTietDatPhong);
			// need add some method to make defaut chiTietDatPhong
			if (chiTietDatPhong == null)
			{
				//chiTietDatPhong
			}
			PhieuDatPhongBUS.Add(phieuDatPhong);
			chiTietDatPhong = null;
		}

		private void btnChiTiet_Click(object sender, EventArgs e)
		{
			new FormChiTietDatPhong(chiTietDatPhong).Show();
		}

		private void btnXem_Click(object sender, EventArgs e)
		{
			DateTime bd = new DateTime(2016, 11, 4);
			DateTime kt = new DateTime(2016, 11, 11);
			dataGridViewPhong.DataSource = PhongBUS.GetAllPhongTrong(bd, kt);
			switch (comboBox1.SelectedIndex)
			{
				case 1:
					dataGridViewPhong.DataSource = PhongBUS.GetLoai(LoaiPhong.A);
					break;
				case 2:
					dataGridViewPhong.DataSource = PhongBUS.GetLoai(LoaiPhong.B);
					break;
				case 3:
					dataGridViewPhong.DataSource = PhongBUS.GetLoai(LoaiPhong.C);
					break;
				case 4:
					dataGridViewPhong.DataSource = PhongBUS.GetLoai(LoaiPhong.D);
					break;
				default:
					
					break;
			}
		}
	}
}
