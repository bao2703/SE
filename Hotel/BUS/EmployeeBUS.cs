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
			using (var unitOfWork = new UnitOfWork())
			{
				return unitOfWork.Employees.Any(e => e.EmployeeId == employee.EmployeeId && e.Password == employee.Password);
			}
		}
    }
}
