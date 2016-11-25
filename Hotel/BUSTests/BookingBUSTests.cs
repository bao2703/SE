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
			AutoMapperConfiguration.Configure();
		}

		[TestMethod()]
		public void GetBookingsTest()
		{
			Assert.Fail();
		}
	}
}