using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Domain;

namespace DAO.Repositories
{
	public class CustomerRepository : Repository<Customer>
	{
		public CustomerRepository(DbContext context) : base(context)
		{
		}

		public IList<Customer> GetCustomerByPhone(string phone)
		{
			return HotelContext.Customers.Where(a => a.Phone == phone).ToList();
		}

		public IList<Customer> GetCustomerByFax(string fax)
		{

			return HotelContext.Customers.Where(a => a.Fax == fax).ToList();

		}

		public IList<Customer> GetCustomerByTelex(string telex)
		{
			return HotelContext.Customers.Where(a => a.Telex == telex).ToList();
		}

		public IList<Customer> GetCustomersWithBookings()
		{
			var customers = HotelContext.Customers.Include(a => a.Bookings).ToList();
			return customers;
		}

		public HotelContext HotelContext
		{
			get
			{
				return context as HotelContext;
			}
		}
	}
}
