using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class PhieuThuePhong
	{
		private static string prefixId = "TP";

		private string id;
		private KhachHang khachHang;
		private NhanVien nhanVien;
		private DateTime ngayNhan;
		private DateTime ngayTra;
		private List<ChiTietThuePhong> chiTietThuePhong;

		public PhieuThuePhong(string id, KhachHang khachHang, NhanVien nhanVien, DateTime ngayNhan, DateTime ngayTra, List<ChiTietThuePhong> chiTietThuePhong)
		{
			this.id = id;
			this.khachHang = khachHang;
			this.nhanVien = nhanVien;
			this.ngayNhan = ngayNhan;
			this.ngayTra = ngayTra;
			this.chiTietThuePhong = chiTietThuePhong;
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

		public DateTime NgayNhan
		{
			get { return ngayNhan; }
			set { ngayNhan = value; }
		}

		public DateTime NgayTra
		{
			get { return ngayTra; }
			set { ngayTra = value; }
		}

		public List<ChiTietThuePhong> ChiTietThuePhong
		{
			get { return chiTietThuePhong; }
			set { chiTietThuePhong = value; }
		}
		#endregion
	}
}
