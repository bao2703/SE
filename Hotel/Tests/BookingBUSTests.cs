namespace BUS.Tests
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using BUS;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class BookingBUSTests
	{
		public BookingBUSTests()
		{
			AutoMapperConfiguration.Configure();
		}

		[TestMethod]
		public void GetBookingsTest()
		{
			var actual = BookingBUS.GetBookings().Count;
			var expected = 2;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void GetBookingsByContainsIdTest()
		{
			var actual = BookingBUS.GetBookingsByContainsId("1").Count;
			var expected = 1;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void NextBookingIdTest_TC1()
		{
			var actual = BookingBUS.NextId();
			var expected = "B0001";
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void NextBookingIdTest_TC2()
		{
			var actual = BookingBUS.NextId();
			var expected = "B0003";
			Assert.AreEqual(expected, actual);
		}
	}
}