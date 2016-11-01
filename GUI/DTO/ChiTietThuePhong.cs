using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class ChiTietThuePhong
	{
		private Phong phong;
		private int soLuongKhach;
		private int tienThue;

		public ChiTietThuePhong(Phong phong, int soLuongKhach, int tienThue)
		{
			this.phong = phong;
			this.soLuongKhach = soLuongKhach;
			this.tienThue = tienThue;
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

		public int TienThue
		{
			get { return tienThue; }
			set { tienThue = value; }
		}
		#endregion
	}
}