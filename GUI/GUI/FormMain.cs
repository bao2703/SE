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
		private DataTable dataTableChiTietDatPhogn;
		private DataTable dataTablePhong;
		private List<Phong> a;
		private DataColumn dataColumnIdPhong = new DataColumn("Id", typeof(string));
		private DataColumn dataColumnLoaiPhong = new DataColumn("Loai", typeof(string));
		private NhanVien nhanVien;
		public FormMain(NhanVien nhanVien)
		{
			InitializeComponent();
			this.nhanVien = nhanVien;
			lblTenNhanVien.Text = nhanVien.Ten;
			dataGridViewKhachHang.DataSource = KhachHangBUS.GetAll();

			dataTableChiTietDatPhogn = new DataTable();
			dataTableChiTietDatPhogn.Columns.Add(dataColumnIdPhong);
			dataTableChiTietDatPhogn.Columns.Add(dataColumnLoaiPhong);
			dataTableChiTietDatPhogn.Columns.Add("SoLuongKhach", typeof(int));
			dataGridViewChiTietDatPhong.DataSource = dataTableChiTietDatPhogn;
		}

		private KhachHang GetInputKhachHang()
		{
			KhachHang khachHang = new KhachHang();
			khachHang.Id = KhachHangBUS.NextId();
			khachHang.Ten = txtHoTen.Text;
			khachHang.DiaChi = txtDiaChi.Text;
			khachHang.SoDienThoai = txtSoDienThoai.Text;
			khachHang.Fax = txtFax.Text;
			khachHang.Telex = txtTelex.Text;
			return khachHang;
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
			PhieuDatPhong phieuDatPhong = new PhieuDatPhong(PhieuDatPhongBUS.NextId(), txtMaKhachHang.Text, nhanVien.Id, DateTime.Now,
				dateTimeNgayDen.Value, dateTimeNgayDi.Value);
			PhieuDatPhongBUS.Add(phieuDatPhong);
		}

		private void btnXemPhong_Click(object sender, EventArgs e)
		{


			a = PhongBUS.GetAll();
			dataGridViewPhong.DataSource = a;

		}

		private void btnThemKhachHang_Click(object sender, EventArgs e)
		{
			KhachHangBUS.Add(GetInputKhachHang());
			dataGridViewKhachHang.DataSource = KhachHangBUS.GetAll();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DataRow row = dataTableChiTietDatPhogn.NewRow();
			if (dataGridViewPhong.SelectedCells.Count == 1)
			{
				foreach (DataGridViewCell item in dataGridViewPhong.SelectedCells)
				{
					row["Id"] = item.OwningRow.Cells["Id"].Value.ToString();
					row["Loai"] = item.OwningRow.Cells["Loai"].Value.ToString();
					row["SoLuongKhach"] = 1;
					dataTableChiTietDatPhogn.Rows.Add(row);
					a.RemoveAt(item.OwningRow.Index);
				}
			}
			dataGridViewPhong.DataSource = a;
		}
	}
}
