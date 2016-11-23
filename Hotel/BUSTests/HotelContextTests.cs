using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAO.Tests
{
	public static class DbClear
	{
		public static void Exec<T>(this DbSet<T> dbSet) where T : class
		{
			dbSet.RemoveRange(dbSet);
		}
	}
	[TestClass()]
	public class HotelContextTests
	{
		[TestMethod()]
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