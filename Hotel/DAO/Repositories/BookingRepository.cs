using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Domain;

namespace DAO.Repositories
{
	public class BookingRepository : Repository<Booking>
	{
		public BookingRepository(DbContext context) : base(context)
		{
		}

		public IEnumerable<Booking> GetContainsBookingId(string bookingId)
		{
			return HotelContext.Bookings
				.Where(b => b.BookingId.Contains(bookingId));
		}
	}
}
