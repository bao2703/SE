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

		public int NumOfCustomer { get; set; }
	}
}
