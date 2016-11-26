
namespace Tests
{
	using BUS;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	[TestClass]
	public class RoomBUSTests
	{
		public RoomBUSTests()
		{
			AutoMapperConfiguration.Configure();
		}

		[TestMethod]
		public void GetAvailableRoomsTest()
		{
			var start = new DateTime(2016, 11, 20);
			var end = new DateTime(2016, 11, 30);
			var actual = RoomBUS.GetAvailableRooms(start, end).Count;
			var expected = 115;
			Assert.AreEqual(expected, actual);
		}
	}
}