using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using DAO.Domain;
using AutoMapper;
using System.ComponentModel;
using System.Windows.Forms;

namespace BUS
{
	public static class BookingBUS
	{
		public static List<BookingDTO> GetBookings()
		{
			using (var context = new HotelContext())
			{
				var booking = context.Bookings.ToList();
				int a = 0;
				if (5 == 5)
					a = 10 + a;
				return Mapper.Map<List<Booking>, List<BookingDTO>>(booking);
			}
		}

		public static void Add(BookingDTO booking)
		{
			using (var context = new HotelContext())
			{
				//booking.BookingDetails.ForEach(x => context.RoomTypes.Attach(Mapper.Map<RoomTypeDTO, RoomType>(x.Room.RoomType)));
				booking.BookingDetails.ForEach(b => b.Room = null);
				context.Bookings.Add(Mapper.Map<BookingDTO, Booking>(booking));
				context.SaveChanges();
			}
		}

        /// <summary>
        /// Tìm mã khách hàng tiếp theo
        /// </summary>
        /// <returns></returns>
		public static string NextId()
		{
			using (var context = new HotelContext())
			{
				var query = context.Customers.OrderByDescending(c => c.CustomerId).FirstOrDefault();
				var prefixId = BookingDTO.PrefixId;
				if (query == null)
				{
					return Utilities.NextId("", prefixId);
				}
				return Utilities.NextId(query.CustomerId, prefixId);
			}
		}
	}
}
