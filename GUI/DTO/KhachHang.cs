using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class KhachHang
	{
		private static string prefixId = "KH";

		private string id;
		private string ten;
		private string diaChi;
		private string soDienThoai;
		private string fax;
		private string telex;

		public KhachHang()
		{

		}

		public KhachHang(string id, string ten, string diaChi, string soDienThoai)
		{
			this.id = id;
			this.ten = ten;
			this.diaChi = diaChi;
			this.soDienThoai = soDienThoai;
		}

		public KhachHang(string id, string ten, string diaChi, string soDienThoai, string fax, string telex)
		{
			this.id = id;
			this.ten = ten;
			this.diaChi = diaChi;
			this.soDienThoai = soDienThoai;
			this.fax = fax;
			this.telex = telex;
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

		public string Ten
		{
			get { return ten; }
			set { ten = value; }
		}

		public string DiaChi
		{
			get { return diaChi; }
			set { diaChi = value; }
		}

		public string SoDienThoai
		{
			get { return soDienThoai; }
			set { soDienThoai = value; }
		}

		public string Fax
		{
			get { return fax; }
			set { fax = value; }
		}

		public string Telex
		{
			get { return telex; }
			set { telex = value; }
		}
		#endregion
	}
}
