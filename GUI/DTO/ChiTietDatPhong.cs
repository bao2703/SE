using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class ChiTietDatPhong
	{
		private string idPhieuDatPhong;
		private string idPhong;
		private int soLuongKhach;

		public ChiTietDatPhong(string idPhieuDatPhong, string idPhong, int soLuongKhach)
		{
			this.idPhieuDatPhong = idPhieuDatPhong;
			this.idPhong = idPhong;
			this.soLuongKhach = soLuongKhach;
		}

		#region Properties
		public string IdPhieuDatPhong
		{
			get { return idPhieuDatPhong; }
			set { idPhieuDatPhong = value; }
		}

		public string IdPhong
		{
			get { return idPhong; }
			set { idPhong = value; }
		}

		public int SoLuongKhach
		{
			get { return soLuongKhach; }
			set { soLuongKhach = value; }
		}
		#endregion
	}
}
