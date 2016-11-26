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
        /// <summary>
        /// Lấy ra thông tin của nhân viên thông qua ID
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
		public static EmployeeDTO GetEmployeeById(string employeeId)
		{
			using (var context = new HotelContext())
			{
				var employee = context.Employees.Find(employeeId);
				return Mapper.Map<Employee, EmployeeDTO>(employee);
			}
		}

        /// <summary>
        /// Kiểm tra ID và Password của nhân viên hợp lệ
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
		public static bool IsValid(EmployeeDTO employee)
		{
			using (var context = new HotelContext())
			{
				return context.Employees.Any(e => e.EmployeeId == employee.EmployeeId && e.Password == employee.Password);
			}
		}
	}
}
