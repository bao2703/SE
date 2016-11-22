using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Domain;

namespace DAO.Repositories
{
	public class CustomerRepository : Repository<Customer>
	{ 
		public CustomerRepository(DbContext context) : base(context)
		{
		}
	}
}
