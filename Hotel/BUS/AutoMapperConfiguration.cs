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

				c.CreateMap<CheckInDTO, CheckIn>();

				c.CreateMap<RoomDTO, Room>();

				c.CreateMap<RoomTypeDTO, RoomType>();

				c.CreateMap<BookingDetail, BookingDetailDTO>();

				c.CreateMap<Booking, BookingDTO>();

				c.CreateMap<Customer, CustomerDTO>();

				c.CreateMap<CheckIn, CheckInDTO>();

				c.CreateMap<CheckInDetail, CheckInDetailDTO>();

				c.CreateMap<Employee, EmployeeDTO>();

				c.CreateMap<Room, RoomDTO>();

				c.CreateMap<RoomType, RoomTypeDTO>();

				c.CreateMap<Booking, CheckIn>()
					.ForMember(d => d.Customer, o => o.Ignore())
					.ForMember(d => d.Employee, o => o.Ignore())
					.ForMember(d => d.CreatedDate, o => o.Ignore())
					.ForMember(d => d.CheckInDetails, o => o.MapFrom(s => s.BookingDetails));

				c.CreateMap<BookingDetail, CheckInDetail>()
					.ForMember(d => d.CheckInDate, o => o.MapFrom(s => s.BookingStart))
					.ForMember(d => d.CheckOutDate, o => o.MapFrom(s => s.BookingEnd))
					.ForMember(d => d.Room, o => o.Ignore());
			});
		}
	}
}
