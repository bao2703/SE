using System;
using DAO.Repositories;

namespace DAO.Core
{
	public interface IUnitOfWork : IDisposable
	{
		BookingDetailRepository BookingDetails { get; }

		BookingRepository Bookings { get; }

		CustomerRepository Customers { get; }

		EmployeeRepository Employees { get; }

		RoomRepository Rooms { get; }

		ServiceRepository Services { get; }

		int SaveChanges();
	}
}