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

		public IEnumerable<Room> FilterRoomsByType(string typeId, IEnumerable<Room> rooms)
		{
			return rooms.Where(r => r.TypeId == typeId);
		}

		public IEnumerable<Room> GetAvailableRooms(DateTime startDate, DateTime endDate)
		{
			return HotelContext.Rooms.Where(r => 
				!(r.BookingDetails.Any(b => (b.BookingStart.CompareTo(endDate) == -1 || b.BookingStart.CompareTo(endDate) == 0) &&
				(b.BookingEnd.CompareTo(startDate) == 1 || b.BookingEnd.CompareTo(startDate) == 0))));
		}
	}
}
