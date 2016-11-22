using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Repositories;
using DTO.Domain;

namespace DAO
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly HotelContext hotelContext;

		public UnitOfWork()
		{
			this.hotelContext = new HotelContext();
			Bookings = new BookingRepository(hotelContext);
			Employees = new EmployeeRepository(hotelContext);
			Customers = new CustomerRepository(hotelContext);
			Rooms = new RoomRepository(hotelContext);
			Services = new ServiceRepository(hotelContext);
			BookingDetails = new BookingDetailRepository(hotelContext);
		}

		public BookingRepository Bookings { get; private set; }
		public EmployeeRepository Employees { get; private set; }
		public CustomerRepository Customers { get; private set; }
		public RoomRepository Rooms { get; private set; }
		public ServiceRepository Services { get; private set; }
		public BookingDetailRepository BookingDetails { get; private set; }

		public int SaveChanges()
		{
			return this.hotelContext.SaveChanges();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		public void Dispose()
		{
			this.hotelContext.Dispose();
		}
	}
}
