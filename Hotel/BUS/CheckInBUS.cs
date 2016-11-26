namespace BUS
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using AutoMapper;
	using DAO;
	using DAO.Domain;
	using DTO;

	public static class CheckInBUS
	{
		public static List<CheckInDTO> GetCheckIns()
		{
			using (var context = new HotelContext())
			{
				var checkIns = context.CheckIns
					.Where(c => !context.Invoices.Any(i => c.CheckInId == i.CheckInId))
					.ToList();
				return Mapper.Map<List<CheckIn>, List<CheckInDTO>>(checkIns);
			}
		}

		public static void AddCheckIn(CheckInDTO checkIn)
		{
			using (var context = new HotelContext())
			{
				context.CheckIns.Add(Mapper.Map<CheckInDTO, CheckIn>(checkIn));
				context.SaveChanges();
			}
		}

		public static void AddCheckInBaseOnBooking(string bookingId)
		{
			using (var context = new HotelContext())
			{
				var booking = context.Bookings.Find(bookingId);
				if (booking == null)
				{
					throw new InvalidOperationException();
				}
				if (context.CheckIns.Where(c => c.BookingId == bookingId).FirstOrDefault() != null)
				{
					throw new InvalidOperationException();
				}
				var checkIn = Mapper.Map<Booking, CheckIn>(booking);
				checkIn.CheckInId = CheckInBUS.NextId();
				checkIn.CreatedDate = DateTime.Now;
				context.CheckIns.Add(checkIn);
				context.SaveChanges();
			}
		}

		/// <summary>
		/// Tìm mã nhận phòng tiếp theo
		/// </summary>
		/// <returns></returns>
		public static string NextId()
		{
			using (var context = new HotelContext())
			{
				var query = context.CheckIns.OrderByDescending(c => c.CheckInId).FirstOrDefault();
				var prefixId = CheckInDTO.PrefixId;
				if (query == null)
				{
					return Utilities.NextId(string.Empty, prefixId);
				}
				return Utilities.NextId(query.CheckInId, prefixId);
			}
		}
	}
}
