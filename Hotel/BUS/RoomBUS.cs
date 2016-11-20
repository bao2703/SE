using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using DTO.BindingModel;
using DTO.Domain;

namespace BUS
{
	public static class RoomBUS
	{
		public static List<RoomBindingModel> GetAvailableRoomsForBinding(int typeOfRoom, DateTime startDate, DateTime endDate)
		{
			using (var unitOfWork = new UnitOfWork())
			{
				var rooms = unitOfWork.Rooms.GetAvailableRooms(startDate, endDate);
				if (typeOfRoom >= 1 && typeOfRoom <= 4)
				{
					rooms = rooms.Where(r => r.TypeId == typeOfRoom.ToString());
				}
				return Apdapter.Exec(rooms);
			}
		}
	}
}
