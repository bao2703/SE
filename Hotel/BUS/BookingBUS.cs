using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO.Domain;
using DTO.BindingModel;
using System.ComponentModel;

namespace BUS
{
	public static class BookingBUS
	{
		public static BindingList<BookingBindingModel> GetBookingsForBinding()
		{
			using (var unitOfWork = new UnitOfWork())
			{
				return Adapter.Exec(unitOfWork.Bookings.ToList());
			}
		}

		public static void Add(Booking booking)
		{
			using (var unitOfWork = new UnitOfWork())
			{
				unitOfWork.Bookings.Add(booking);
				unitOfWork.SaveChanges();
			}
		}

		public static string NextId()
		{
			using (var unitOfWork = new UnitOfWork())
			{
				var query = unitOfWork.Customers.OrderByDescending(c => c.CustomerId).FirstOrDefault();
				var prefixId = Booking.PrefixId;
				if (query == null)
				{
					return Utilities.NextId("", prefixId);
				}
				return Utilities.NextId(query.CustomerId, prefixId);
			}
		}
	}
}
