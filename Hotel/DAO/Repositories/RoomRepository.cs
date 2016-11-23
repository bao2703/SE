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

		public IEnumerable<Room> GetAll()
		{
			return HotelContext.Rooms
				.Include(r => r.RoomType)
				.Include(r => r.BookingDetails)
				.Include(r => r.CheckInDetails);
		}
	}
}
