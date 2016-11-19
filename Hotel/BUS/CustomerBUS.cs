using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO.Domain;
using DTO.BindingModel;

namespace BUS
{
	public static class CustomerBUS
	{
		public static Customer GetCustomerById(string customerId)
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

		public static void Remove(string customerId)
		{
			using (var unitOfWork = new UnitOfWork())
			{
				var removeCustomers = unitOfWork.Customers.Find(customerId);
				unitOfWork.Customers.Remove(removeCustomers);
				unitOfWork.SaveChanges();
			}
		}

		public static string NextId()
		{
			using (var unitOfWork = new UnitOfWork())
			{
				var query = unitOfWork.Customers.OrderByDescending(c => c.CustomerId).FirstOrDefault();
				var prefixId = Customer.PrefixId;
				if (query == null)
				{
					return Utilities.NextId("", prefixId);
				}
				return Utilities.NextId(query.CustomerId, prefixId);
			}
		}
	}
}
