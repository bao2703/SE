using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
	public class DichVu
	{
		private string id;
		private string ten;
		private int donGia;
		public DichVu()
		{
		}

		public DichVu(string id, string ten, int donGia)
		{
			this.id = id;
			this.ten = ten;
			this.donGia = donGia;
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

		public int DonGia
		{
			get { return donGia; }
			set { donGia = value; }
		}
	}
}
