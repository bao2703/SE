using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class BookingDTO
	{
		public BookingDTO()
		{
		}

		public string BookingId { get; set; }

		public DateTime CreatedDate { get; set; }

		public virtual CustomerDTO Customer { get; set; }
	}
}
