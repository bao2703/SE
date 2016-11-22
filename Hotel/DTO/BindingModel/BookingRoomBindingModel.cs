using DTO.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.BindingModel
{
	public class BookingRoomBindingModel : RoomBindingModel
	{
		public BookingRoomBindingModel() : base()
		{
		}

		public DateTime BookingStart { get; set; }

		public DateTime BookingEnd { get; set; }

		public int NumOfCustomer { get; set; }
	}
}
