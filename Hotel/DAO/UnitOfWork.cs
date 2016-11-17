using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Repositories;
using DTO.Domain;

namespace DAO
{
	public class UnitOfWork : IDisposable
	{
		private readonly HotelContext context;

		public UnitOfWork()
		{
			this.context = new HotelContext();
			Employees = new EmployeeRepository(context);
		}

		public UnitOfWork(HotelContext context)
		{
			this.context = context;
			Employees = new EmployeeRepository(context);
		}

		public EmployeeRepository Employees { get; private set; }

		public int Complete()
		{
			return this.context.SaveChanges();
		}

		public void Dispose()
		{
			this.context.Dispose();
		}
	}
}
