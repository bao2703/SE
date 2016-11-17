using Microsoft.VisualStudio.TestTools.UnitTesting;
using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Domain;

namespace BUS.Tests
{
	[TestClass()]
	public class CustomerBUSTests
	{
		private Customer expected = new Customer()
		{
			CustomerId = "1"
		};

		[TestMethod()]
		public void GetCustomerByIdTest()
		{
			var actual = CustomerBUS.GetCustomerById("1");
			Assert.AreEqual(expected.CustomerId, actual.CustomerId);
		}

		[TestMethod()]
		public void AddTest()
		{
			var id = "1";
			var newCustomer = new Customer()
			{
				CustomerId = id
			};
			CustomerBUS.Add(newCustomer);
			Assert.IsTrue(true);
		}

		[TestMethod()]
		public void RemoveTest()
		{
			var removeCustomerId = "1";
			CustomerBUS.Remove(removeCustomerId);
			Assert.IsTrue(true);
		}

		[TestMethod()]
		public void CountTest()
		{
			var actual = CustomerBUS.Count();
			var expected = 1;
			Assert.AreEqual(expected, actual);
		}
	}
}