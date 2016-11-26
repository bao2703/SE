namespace Tests
{
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using DAO;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	public static class DbClear
	{
		public static void Exec<T>(this DbSet<T> dbSet) where T : class
		{
			dbSet.RemoveRange(dbSet);
		}
	}

	[TestClass]
	public class HotelContextTests
	{
		[TestMethod]
		public void ClearAllData()
		{
			using (var context = new HotelContext())
			{
				DbClear.Exec(context.BookingDetails);
				DbClear.Exec(context.Bookings);
				DbClear.Exec(context.Customers);
				context.SaveChanges();
			}
			Assert.IsTrue(true);
		}
	}
}