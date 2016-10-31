using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class ChiTietDatPhong
	{
		private Phong phong;
		private int soLuongKhach;
		private DateTime ngayDen;
		private DateTime ngayDi;

		public ChiTietDatPhong(Phong phong, int soLuongKhach, DateTime ngayDen, DateTime ngayDi)
		{
			this.phong = phong;
			this.soLuongKhach = soLuongKhach;
			this.ngayDen = ngayDen;
			this.ngayDi = ngayDi;
		}

		#region Properties
		public Phong Phong
		{
			get { return phong; }
			set { phong = value; }
		}

		public int SoLuongKhach
		{
			get { return soLuongKhach; }
			set { soLuongKhach = value; }
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
