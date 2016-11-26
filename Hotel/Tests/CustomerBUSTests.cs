namespace Tests
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using BUS;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class CustomerBUSTests
	{
		[TestMethod]
		public void NextCustomerIdTest_TC1()
		{
			var actual = CustomerBUS.NextId();
			var expected = "C0001";
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void NextCustomerIdTest_TC2()
		{
			var actual = CustomerBUS.NextId();
			var expected = "C0003";
			Assert.AreEqual(expected, actual);
		}
	}
}