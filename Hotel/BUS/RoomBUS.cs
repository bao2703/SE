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
		public static List<Room> GetAvailableRooms(IEnumerable<Room> rooms, DateTime startDate, DateTime endDate)
		{
			var temp = rooms.Where(r =>
					!(r.BookingDetails.Any(b => !(b.BookingStart.CompareTo(endDate) == 1 || b.BookingEnd.CompareTo(startDate) == -1)) ||
					(r.CheckInDetails.Any(c => !(c.CheckInDate.CompareTo(endDate) == 1 || c.CheckOutDate.CompareTo(startDate) == -1)))));
			return temp.OrderBy(r=> r.RoomId.Length).ThenBy(r => r.RoomId).ToList();
		}

		public static List<Room> GetAll()
		{
			using (var unitOfWork = new UnitOfWork())
			{
				return unitOfWork.Rooms.GetAll().ToList();
			}
		}
	}
}
