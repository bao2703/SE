using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class PhieuDatPhong
	{
		private static string prefixId = "DP";

		private string id;
		private KhachHang khachHang;
		private NhanVien nhanVien;
		private DateTime ngayDat;
		private int soLuongPhong;
		private int soLuongKhach;
		private List<ChiTietDatPhong> chiTietDatPhong;

		public PhieuDatPhong()
		{
		}

		public PhieuDatPhong(string id, KhachHang khachHang, NhanVien nhanVien, DateTime ngayDat,
			int soLuongPhong, int soLuongKhach, List<ChiTietDatPhong> chiTietDatPhong)
		{
			this.id = id;
			this.khachHang = khachHang;
			this.nhanVien = nhanVien;
			this.ngayDat = ngayDat;
			this.soLuongPhong = soLuongPhong;
			this.soLuongKhach = soLuongKhach;
			this.chiTietDatPhong = chiTietDatPhong;
		}

		#region Properties
		public static string PrefixId
		{
			get { return prefixId; }
		}

		public string Id
		{
			get { return id; }
			set { id = value; }
		}

		public KhachHang KhachHang
		{
			get { return khachHang; }
			set { khachHang = value; }
		}

		public NhanVien NhanVien
		{
			get { return nhanVien; }
			set { nhanVien = value; }
		}

		public DateTime NgayDat
		{
			get { return ngayDat; }
			set { ngayDat = value; }
		}

		public int SoLuongPhong
		{
			get { return soLuongPhong; }
			set { soLuongPhong = value; }
		}

		public int SoLuongKhach
		{
			get { return soLuongKhach; }
			set { soLuongKhach = value; }
		}

		public List<ChiTietDatPhong> ChiTietDatPhong
		{
			get { return chiTietDatPhong; }
			set { chiTietDatPhong = value; }
		}
		#endregion
	}
}
