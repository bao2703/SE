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
		public static List<RoomBindingModel> GetAvailableRoomsForBinding(TypeOfRoom? typeOfRoom, DateTime startDate, DateTime endDate)
		{
			using (var unitOfWork = new UnitOfWork())
			{
				var rooms = unitOfWork.Rooms.GetAvailableRooms(startDate, endDate);
				if (typeOfRoom != null)
				{
					rooms = rooms.Where(r => r.RoomType.TypeName == typeOfRoom);
				}
				return Apdapter.Exec(rooms);
			}
		}
	}
}
