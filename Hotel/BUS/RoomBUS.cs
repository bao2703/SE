﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using DAO.Domain;
using System.ComponentModel;
using AutoMapper;

namespace BUS
{
	public static class RoomBUS
	{
		public static List<RoomDTO> GetAvailableRooms(DateTime startDate, DateTime endDate)
		{
			using (var context = new HotelContext())
			{
				var rooms = context.Rooms.Where(r =>
					!(r.BookingDetails.Any(b => !(b.BookingStart.CompareTo(endDate) == 1 || b.BookingEnd.CompareTo(startDate) == -1)) ||
					(r.CheckInDetails.Any(c => !(c.CheckInDate.CompareTo(endDate) == 1 || c.CheckOutDate.CompareTo(startDate) == -1)))))
				.OrderBy(r => r.RoomId.Length)
				.ThenBy(r => r.RoomId)
				.ToList();
				return Mapper.Map<List<Room>, List<RoomDTO>>(rooms);
			}
		}
	}
}
