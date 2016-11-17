using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Domain;

namespace DAO.Repositories
{
	public class ServiceRepository : Repository<Service>
	{
		public ServiceRepository(DbContext context) : base(context)
		{
		}
	}
}
