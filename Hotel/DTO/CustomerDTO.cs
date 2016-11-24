using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class CustomerDTO
	{
		public CustomerDTO()
		{
		}

		public string CustomerId { get; set; }

		public string Name { get; set; }

		public string Address { get; set; }

		public string Phone { get; set; }

		public string Fax { get; set; }

		public string Telex { get; set; }
	}
}
