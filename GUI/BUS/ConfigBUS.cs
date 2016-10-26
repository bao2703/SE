using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
	public static class ConfigBUS
	{
		private const string conStrWindows = @"Data Source = {0}; Initial Catalog = {1}; Integrated Security = True;";
		private const string conStrSQLServer = @"Data Source = {0}; Initial Catalog = {1}; User ID = {2}; Password = {3};";

		/// <summary>
		/// Hàm sửa cấu hình quyền Windows
		/// </summary>
		/// <param name="config"></param>
		public static void WindowsAuthentication(Config config)
		{
			ConfigDAO.ChangeConnectionString(string.Format(conStrWindows, config.ServerName, config.DatabaseName));
			ConfigDAO.SetAppConfig(config);
		}

		/// <summary>
		/// Hàm sửa cấu hình quyền SQL Server
		/// </summary>
		/// <param name="config"></param>
		public static void SQLSeverAuthentication(Config config)
		{
			ConfigDAO.ChangeConnectionString(
				string.Format(conStrSQLServer, config.ServerName, config.DatabaseName, config.Username, config.Password));
			ConfigDAO.SetAppConfig(config);
		}

		public static Config GetAppConfig()
		{
			return ConfigDAO.GetAppConfig();
		}
	}
}
