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
		private DateTime ngayDen;
		private DateTime ngayDi;
		private List<ChiTietDatPhong> chiTietDatPhong;

		public PhieuDatPhong()
		{
		}

		public PhieuDatPhong(string id, KhachHang khachHang, NhanVien nhanVien, DateTime ngayDat, DateTime ngayDen, DateTime ngayDi)
		{
			this.id = id;
			this.khachHang = khachHang;
			this.nhanVien = nhanVien;
			this.ngayDat = ngayDat;
			this.ngayDen = ngayDen;
			this.ngayDi = ngayDi;
		}

		public PhieuDatPhong(string id, KhachHang khachHang, NhanVien nhanVien, DateTime ngayDat, DateTime ngayDen, DateTime ngayDi, List<ChiTietDatPhong> chiTietDatPhong)
		{
			this.id = id;
			this.khachHang = khachHang;
			this.nhanVien = nhanVien;
			this.ngayDat = ngayDat;
			this.ngayDen = ngayDen;
			this.ngayDi = ngayDi;
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

		public DateTime NgayDen
		{
			get { return ngayDen; }
			set { ngayDen = value; }
		}

		public DateTime NgayDi
		{
			get { return ngayDi; }
			set { ngayDi = value; }
		}

		public List<ChiTietDatPhong> ChiTietDatPhong
		{
			get { return chiTietDatPhong; }
			set { chiTietDatPhong = value; }
		}
		#endregion
	}
}
