using Microsoft.VisualStudio.TestTools.UnitTesting;
using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using DAO.Domain;

namespace BUS.Tests
{
	[TestClass()]
	public class EmployeeBUSTests
	{
		public EmployeeBUSTests()
		{
			MapperConfiguration.Configure();
		}

		#region IsValidTest
		[TestMethod()]
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

		[TestMethod()]
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