using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class NhanVien
	{
		private string id;
		private string ten;
		private string matKhau;

		public NhanVien()
		{
		}

		public NhanVien(string id)
		{
			this.id = id;
		}

		public NhanVien(string id, string matKhau)
		{
			this.id = id;
			this.matKhau = matKhau;
		}

		public NhanVien(string id, string ten, string matKhau)
		{
			this.id = id;
			this.ten = ten;
			this.matKhau = matKhau;
		}

		#region Properties
		public string Id
		{
			get { return id; }
			set { id = value; }
		}

		public string Ten
		{
			get { return ten; }
			set { ten = value; }
		}

		public string MatKhau
		{
			get { return matKhau; }
			set { matKhau = value; }
		}
		#endregion
	}
}
