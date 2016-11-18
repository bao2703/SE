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

		public Room GetRoomWithRoomType(string roomId)
		{
			return HotelContext.Rooms
				.Where(r => r.RoomId == roomId)
				.Include(r => r.RoomType)
				.SingleOrDefault();
		}

		public IList<Room> GetRoomsWithRoomType()
		{
			return HotelContext.Rooms				
				.Include(r => r.RoomType)
				.ToList();
		}
	}
}
