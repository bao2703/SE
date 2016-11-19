using Microsoft.VisualStudio.TestTools.UnitTesting;
using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO.Domain;

namespace BUS.Tests
{
	[TestClass()]
	public class SetUpTest
	{
		[TestMethod()]
		public void SetUp()
		{
			var employee = new Employee()
			{
				EmployeeId = "1",
				Password = "1",
			};
			var customer = new Customer()
			{
				CustomerId = "C0001",
			};
			var booking = new Booking()
			{
				BookingId = "B0001",
				Customer = customer,
				CreatedDate = new DateTime(2016, 11, 19),
				Employee = employee,
			};
			using (var unitOfWork = new UnitOfWork())
			{
				unitOfWork.Bookings.Add(booking);
				unitOfWork.SaveChanges();
			}
		}
	}
}