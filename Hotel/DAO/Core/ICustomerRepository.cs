using System.Collections.Generic;
using DTO.Domain;

namespace DAO.Core
{
	public interface ICustomerRepository : IRepository<Customer>
	{
		Customer GetCustomerWithBookings(string customerId);
	}
}