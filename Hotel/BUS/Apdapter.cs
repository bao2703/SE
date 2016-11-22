using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.BindingModel;
using DTO.Domain;
using System.ComponentModel;

namespace BUS
{
	public static class Apdapter
	{
		public static BookingBindingModel Exec(Booking booking)
		{
			return new BookingBindingModel
			{
				BookingId = booking.BookingId,
				CreatedDate = booking.CreatedDate,
				TotalRoom = booking.BookingDetails.Count(),
				CustomerId = booking.Customer.CustomerId,
				Name = booking.Customer.Name,
				Address = booking.Customer.Address,
				Fax = booking.Customer.Fax,
				Phone = booking.Customer.Phone,
				Telex = booking.Customer.Telex
			};
		}

		public static BindingList<BookingBindingModel> Exec(IEnumerable<Booking> bookings)
		{
			var result = new BindingList<BookingBindingModel>();
			foreach (var item in bookings)
			{
				result.Add(Apdapter.Exec(item));
			}
			return result;
		}

		public static RoomBindingModel Exec(Room room)
		{
			return new RoomBindingModel()
			{
				RoomId = room.RoomId,
				TypeName = room.RoomType.TypeName
			};
		}

		public static BindingList<RoomBindingModel> Exec(IEnumerable<Room> rooms)
		{
			var result = new BindingList<RoomBindingModel>();
			foreach (var item in rooms)
			{
				result.Add(Apdapter.Exec(item));
			}
			return result;
		}
	}
}
