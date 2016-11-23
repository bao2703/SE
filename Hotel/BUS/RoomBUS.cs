using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using DTO.BindingModel;
using DTO.Domain;
using System.ComponentModel;

namespace BUS
{
	public static class RoomBUS
	{
		public static List<Room> GetAvailableRooms(DateTime startDate, DateTime endDate)
		{
			using (var unitOfWork = new UnitOfWork())
			{
				var rooms = unitOfWork.Rooms.GetAvailableRooms(startDate, endDate).OrderBy(r => r.RoomId.Length).ThenBy(r => r.RoomId);
				return rooms.ToList();
			}
		}
	}
}
