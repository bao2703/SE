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
	public class EmployeeBUSTests
	{
		private Employee expected = new Employee()
		{
			EmployeeId = "1",
			Name = "Neptune",
			Password = "1"
		};

		#region GetTest
		[TestMethod()]
		public void GetEmployeeByIdTest_TC1()
		{
			var actual = EmployeeBUS.GetEmployeeById("1");
			Assert.AreEqual(expected.EmployeeId, actual.EmployeeId);
		}

		[TestMethod()]

		public void GetEmployeeByIdTest_TC2()
		{
			var actual = EmployeeBUS.GetEmployeeById("69");
			Assert.IsNull(actual);
		}
		#endregion

		#region IsValidTest
		[TestMethod()]
		public void IsValidTest()
		{
			//var actual = EmployeeBUS.IsValid("1", "1");
			//Assert.IsTrue(actual);
		} 
		#endregion
	}
}