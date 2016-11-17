using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO.Domain;

namespace BUS
{
	public static class CustomerBUS
	{
		public static Customer Get(string customerId)
		{
			using (var unitOfWork = new UnitOfWork())
			{
				return unitOfWork.Customers.Find(customerId);
			}
		}

		public static void Add(Customer customer)
		{
			using (var unitOfWork = new UnitOfWork())
			{
				unitOfWork.Customers.Add(customer);
				unitOfWork.SaveChanges();
			}
		}
	}
}
