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
		//public static List<BookingDTO> GetBookings()
		//{
		//	using (var context = new HotelContext())
		//	{
				
		//	}
		//}

		public static BookingDTO GetBookingById(string bookingId)
		{
			using (var context = new HotelContext())
			{
				var booking = context.Bookings.Where(b => b.BookingId == bookingId).Single();
				return Mapper.Map<BookingDTO>(booking);
			}
		}

		//public static void Add(Booking booking)
		//{
		//	using (var unitOfWork = new UnitOfWork())
		//	{
		//		unitOfWork.Bookings.Add(booking);
		//		unitOfWork.SaveChanges();
		//	}
		//}

		//public static string NextId()
		//{
		//	using (var unitOfWork = new UnitOfWork())
		//	{
		//		var query = unitOfWork.Customers.OrderByDescending(c => c.CustomerId).FirstOrDefault();
		//		var prefixId = Booking.PrefixId;
		//		if (query == null)
		//		{
		//			return Utilities.NextId("", prefixId);
		//		}
		//		return Utilities.NextId(query.CustomerId, prefixId);
		//	}
		//}
	}
}
