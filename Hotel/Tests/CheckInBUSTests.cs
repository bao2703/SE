namespace BUS.Tests
{
	using BUS;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	[TestClass]
	public class CheckInBUSTests
	{
		public CheckInBUSTests()
		{
			AutoMapperConfiguration.Configure();
		}

		[TestMethod]
		public void AddCheckInBaseOnBookingTest_TC1()
		{
			CheckInBUS.AddCheckInBaseOnBooking("B0006");
			Assert.IsTrue(true);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidOperationException))]
		public void AddCheckInBaseOnBookingTest_TC2()
		{
			CheckInBUS.AddCheckInBaseOnBooking("B0001");
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidOperationException))]
		public void AddCheckInBaseOnBookingTest_TC3()
		{
			CheckInBUS.AddCheckInBaseOnBooking("B696969");
		}
	}
}