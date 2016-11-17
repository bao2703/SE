using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO.Domain;

namespace BUS
{
    public static class EmployeeBUS
    {
		public static Employee GetEmployeeById(string employeeId)
		{
			using (var unitOfWork = new UnitOfWork())
			{
				return unitOfWork.Employees.Find(employeeId);
			}
		}

		public static bool IsValid(string employeeId, string password)
		{
			var employee = EmployeeBUS.GetEmployeeById(employeeId);
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
