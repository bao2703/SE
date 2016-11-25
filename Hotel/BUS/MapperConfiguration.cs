using System;
using System.Collections.Generic;
using DTO;
using DAO.Domain;
using AutoMapper;
using System.Windows.Forms;
using System.Data;

namespace BUS
{
	public static class AutoMapperConfiguration
	{
		public static void Configure()
		{
			Mapper.Initialize(c => 
			{
				c.CreateMap<BookingDetailDTO, BookingDetail>();
				c.CreateMap<BookingDTO, Booking>();
				c.CreateMap<CustomerDTO, Customer>();
				c.CreateMap<RoomDTO, Room>();
				c.CreateMap<RoomTypeDTO, RoomType>();

				c.CreateMap<BookingDetail, BookingDetailDTO>();
				c.CreateMap<Booking, BookingDTO>();
				c.CreateMap<Customer, CustomerDTO>();
				c.CreateMap<Employee, EmployeeDTO>();
				c.CreateMap<Room, RoomDTO>();
				c.CreateMap<RoomType, RoomTypeDTO>();
			});
		}
	}
}
