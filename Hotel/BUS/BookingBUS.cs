namespace BUS
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using System.Windows.Forms;
	using AutoMapper;
	using DAO;
	using DAO.Domain;
	using DTO;

	public static class BookingBUS
	{
		public static List<BookingDTO> GetBookings()
		{
			using (var context = new HotelContext())
			{
				var booking = context.Bookings
					.Where(b => !context.CheckIns.Any(c => b.BookingId == c.BookingId))
					.ToList();
				return Mapper.Map<List<Booking>, List<BookingDTO>>(booking);
			}
		}

		public static List<BookingDTO> GetBookingsByContainsId(string bookingId)
		{
			using (var context = new HotelContext())
			{
				var booking = context.Bookings
					.Where(b => b.BookingId.Contains(bookingId))
					.Where(b => !context.CheckIns.Any(c => b.BookingId == c.BookingId))
					.ToList();
				return Mapper.Map<List<Booking>, List<BookingDTO>>(booking);
			}
		}

		public static void AddBooking(BookingDTO booking)
		{
			using (var context = new HotelContext())
			{
				context.Bookings.Add(Mapper.Map<BookingDTO, Booking>(booking));
				context.SaveChanges();
			}
		}

		/// <summary>
		/// Tìm mã dặt phòng tiếp theo
		/// </summary>
		/// <returns></returns>
		public static string NextId()
		{
			using (var context = new HotelContext())
			{
				var query = context.Bookings.OrderByDescending(c => c.BookingId).FirstOrDefault();
				var prefixId = BookingDTO.PrefixId;
				if (query == null)
				{
					return Utilities.NextId(string.Empty, prefixId);
				}
				return Utilities.NextId(query.BookingId, prefixId);
			}
		}
	}
}
