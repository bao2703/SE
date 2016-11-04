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
		private string idKhachHang;
		private string idNhanVien;
		private DateTime ngayDat;
		private DateTime ngayDen;
		private DateTime ngayDi;

		public PhieuDatPhong()
		{
		}

		public PhieuDatPhong(string id, string idKhachHang, string idNhanVien, DateTime ngayDat, DateTime ngayDen, DateTime ngayDi)
		{
			this.id = id;
			this.idKhachHang = idKhachHang;
			this.idNhanVien = idNhanVien;
			this.ngayDat = ngayDat;
			this.ngayDen = ngayDen;
			this.ngayDi = ngayDi;
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

		public string IdKhachHang
		{
			get { return idKhachHang; }
			set { idKhachHang = value; }
		}

		public string IdNhanVien
		{
			get { return idNhanVien; }
			set { idNhanVien = value; }
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
		#endregion
	}
}
