using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class Config
	{
		public Config()
		{
		}

		#region Properties
		public string ServerName { get; set; }

		public string DatabaseName { get; set; }

		public string UserName { get; set; }

		public string Password { get; set; }
		#endregion
	}
}
