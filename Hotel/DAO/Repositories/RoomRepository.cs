using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Domain;

namespace DAO.Repositories
{
	public class RoomRepository : Repository<Room>
	{
		public RoomRepository(DbContext context) : base(context)
		{
		}

		public IEnumerable<Room> GetAvailableRooms(DateTime startDate, DateTime endDate)
		{
			return HotelContext.Rooms.Where(r =>
				!(r.BookingDetails.Any(b => !(b.BookingStart.CompareTo(endDate) == 1 || b.BookingEnd.CompareTo(startDate) == -1)) ||
					(r.CheckInDetails.Any(c => !(c.CheckInDate.CompareTo(endDate) == 1 || c.CheckOutDate.CompareTo(startDate) == -1)))));
		}
	}
}
