using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Domain;
using DAO.Core;

namespace DAO.Repositories
{
	public class CustomerRepository : Repository<Customer>, ICustomerRepository
	{
		public CustomerRepository(DbContext context) : base(context)
		{
		}

		public IList<Customer> GetAll()
		{
			return HotelContext.Customers.ToList();
		}

		public Customer GetCustomerWithBookings(string customerId)
		{
			return HotelContext.Customers
				.Where(a => a.CustomerId == customerId)
				.Include(a => a.Bookings)
				.SingleOrDefault();
		}
	}
}
