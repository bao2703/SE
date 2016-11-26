namespace BUS
{
	using System;
	using AutoMapper;
	using DAO.Domain;
	using DTO;

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
