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
		public void GetTest()
		{
			var actual = CustomerBUS.Get("1");
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
	}
}