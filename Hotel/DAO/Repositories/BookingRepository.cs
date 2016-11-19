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
				.Include(b => b.BookingDetails)
				.Where(b => b.BookingId == bookingId)
				.SingleOrDefault();
		}

		public IList<Booking> GetContainsBookingId(string bookingId)
		{
			return HotelContext.Bookings
				.Where(b => b.BookingId.Contains(bookingId))
				.ToList();
		}
	}
}
