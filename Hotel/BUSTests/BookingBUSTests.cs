using Microsoft.VisualStudio.TestTools.UnitTesting;
using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Tests
{
	[TestClass()]
	public class BookingBUSTests
	{
		public BookingBUSTests()
		{
			MapperConfiguration.Configure();
		}

		[TestMethod()]
		public void GetBookingByIdTest()
		{
			var actual = BookingBUS.GetBookingById("B0001");
			var expected = "B0001";
			Assert.AreEqual(expected, actual.BookingId);
		}
	}
}