using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DAO.Domain;
using DTO;
using AutoMapper;

namespace BUS
{
    public static class EmployeeBUS
    {
		public static bool IsValid(EmployeeDTO employee)
		{
			using (var context = new HotelContext())
			{
				return context.Employees.Any(e => e.EmployeeId == employee.EmployeeId && e.Password == employee.Password);
			}
		}
	}
}
