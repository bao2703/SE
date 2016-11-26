namespace BUS.Tests
{
	using BUS;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	[TestClass()]
	public class UtilitiesTests
	{
		[TestMethod()]
		public void IsValidStartAndEndDateTest()
		{
			var start = new DateTime(2016, 11, 20);
			var end = new DateTime(2016, 11, 30);
			Assert.IsTrue(Utilities.IsValidStartAndEndDate(start, end));
		}
	}
}