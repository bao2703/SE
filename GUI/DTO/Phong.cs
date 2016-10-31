using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class Phong
	{
		private string id;
		private int loai;

		public Phong(string id, int loai)
		{
			this.id = id;
			this.loai = loai;
		}

		public string Id
		{
			get { return id; }
			set { id = value; }
		}

		public int Loai
		{
			get { return loai; }
			set { loai = value; }
		}
	}
}
