using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO.Domain;
using System.Windows.Input;
using System.Windows.Forms;

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

		public static IList<Customer> GetAll()
		{
			using (var unitOfWork = new UnitOfWork())
			{
				return unitOfWork.Customers.GetAll();
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

		public static int Count()
		{
			using (var unitOfWork = new UnitOfWork())
			{
				return unitOfWork.Customers.Count();
			}
		}
	}
}
