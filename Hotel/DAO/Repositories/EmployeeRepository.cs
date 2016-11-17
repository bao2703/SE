using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Domain;

namespace DAO.Repositories
{
	public class EmployeeRepository : Repository<Employee>
	{
		public EmployeeRepository(DbContext context) : base(context)
		{
		}
	}
}
