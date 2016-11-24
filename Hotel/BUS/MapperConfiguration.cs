using System;
using System.Collections.Generic;
using DTO;
using DAO.Domain;
using AutoMapper;
using System.Windows.Forms;
using System.Data;

namespace BUS
{
	public static class MapperConfiguration
	{
		public static void Configure()
		{
			Mapper.Initialize(cfg => cfg.CreateMap<Customer, CustomerDTO>());
			Mapper.Initialize(cfg => cfg.CreateMap<Booking, BookingDTO>()
				.ForMember(d => d.Customer, o => o.())
			);
		}
	}
}
