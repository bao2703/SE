using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Domain;

namespace DAO.Repositories
{
	public class BookingDetailRepository : Repository<BookingDetail>
	{
		public BookingDetailRepository(DbContext context) : base(context)
		{
		}
	}
}
