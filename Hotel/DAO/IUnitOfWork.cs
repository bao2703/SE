using System;
using DAO.Repositories;

namespace DAO
{
	public interface IUnitOfWork : IDisposable
	{
		BookingDetailRepository BookingDetails { get; set; }

		BookingRepository Bookings { get; }

		CustomerRepository Customers { get; }

		EmployeeRepository Employees { get; }

		RoomRepository Rooms { get; }

		ServiceRepository Services { get; }

		int SaveChanges();
	}
}