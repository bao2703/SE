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
		private string loai;

		public Phong()
		{
		}

		public Phong(string id, string loai)
		{
			this.id = id;
			this.loai = loai;
		}

		public string Id
		{
			get { return id; }
			set { id = value; }
		}

		public string Loai
		{
			get { return loai; }
			set { loai = value; }
		}
	}
}
