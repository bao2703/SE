using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Domain;

namespace DAO.Repositories
{
	public class BookingRepository : Repository<Booking>
	{
		public BookingRepository(DbContext context) : base(context)
		{
		}

		public HotelContext HotelContext
		{
			get { return context as HotelContext; }
		}


	}
}
