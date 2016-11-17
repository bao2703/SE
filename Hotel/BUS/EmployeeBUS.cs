using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO.Domain;

namespace BUS
{
    public class EmployeeBUS
    {
		public static Employee Get(string employeeId)
		{
			using (var unitOfWork = new UnitOfWork())
			{
				return unitOfWork.Employees.Find(employeeId);
			}
		}

		public static bool IsValid(string employeeId, string password)
		{
			var employee = EmployeeBUS.Get(employeeId);
			if (employee == null)
			{
				return false;
			}
			else if (employee.Password != password)
			{
				return false;
			}
			return true;
		}
    }
}
