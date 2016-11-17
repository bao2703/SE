using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Domain;

namespace DAO.Repositories
{
	public class BookingRepository : Repository<Booking>
	{
		public BookingRepository(DbContext context) : base(context)
		{
		}

		public Booking GetBookingWithBookingDetails(string bookingId)
		{
			return HotelContext.Bookings
				.Include(a => a.BookingDetails)
				.Where(a => a.BookingId == bookingId)
				.SingleOrDefault();
		}

		public IList<Booking> GetContainBooking(string bookingId)
		{
			return HotelContext.Bookings
				.Where(a => a.BookingId.Contains(bookingId))
				.ToList();
		}
	}
}
