using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
	public class ConfigBUS
	{
		private const string conStrWindows = @"Data Source={0}; Initial Catalog={1}; Integrated Security=True; MultipleActiveResultSets=True; App=EntityFramework";
		private const string conStrSQLServer = @"Data Source = {0}; Initial Catalog = {1}; User ID = {2}; Password = {3}; MultipleActiveResultSets=True; App=EntityFramework";

		/// <summary>
		/// Hàm sửa cấu hình quyền Windows
		/// </summary>
		/// <param name="config"></param>
		public static void WindowsAuthentication(Config config)
		{
			ConfigDAO.ChangeConnectionString(string.Format(conStrWindows, config.ServerName, config.DatabaseName));
		}

		/// <summary>
		/// Hàm sửa cấu hình quyền SQL Server
		/// </summary>
		/// <param name="config"></param>
		public static void SQLSeverAuthentication(Config config)
		{
			ConfigDAO.ChangeConnectionString(string.Format(conStrSQLServer, config.ServerName, config.DatabaseName, config.UserName, config.Password));
		}
	}
}
