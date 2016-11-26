namespace BUS.Tests
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using BUS;
	using DTO;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class EmployeeBUSTests
	{
		public EmployeeBUSTests()
		{
			AutoMapperConfiguration.Configure();
		}

		[TestMethod]
		public void GetEmployeeByIdTest()
		{
			var actual = EmployeeBUS.GetEmployeeById("1");
			var expected = "1";
			Assert.AreEqual(expected, actual.EmployeeId);
		}

		#region IsValidTest
		[TestMethod]
		public void IsValidEmployeeTest_TC1()
		{
			var emp = new EmployeeDTO()
			{
				EmployeeId = "1",
				Password = "1"
			};
			var actual = EmployeeBUS.IsValid(emp);
			Assert.IsTrue(actual);
		}

		[TestMethod]
		public void IsValidEmployeeTest_TC2()
		{
			var emp = new EmployeeDTO()
			{
				EmployeeId = "1",
				Password = "69"
			};
			var actual = EmployeeBUS.IsValid(emp);
			Assert.IsFalse(actual);
		}
		#endregion
	}
}