using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class BookingDetailDTO
	{
		public string BookingId { get; set; }

		public string RoomId { get; set; }

		public DateTime BookingStart { get; set; }

		public DateTime BookingEnd { get; set; }

		public int NumOfCustomer { get; set; }
	
		public RoomDTO Room { get; set; }
	}
}
