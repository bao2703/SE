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

		public static bool IsValid(Employee employee)
		{
			var emp = EmployeeBUS.GetEmployeeById(employee.EmployeeId);
			if (employee == null)
			{
				return false;
			}
			else if (emp.Password != employee.Password)
			{
				return false;
			}
			return true;
		}
    }
}
