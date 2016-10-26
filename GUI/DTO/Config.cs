using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class Config
	{
		private string serverName;
		private string databaseName;
		private bool windowsAuthentication;
		private string username;
		private string password;

		public Config()
		{
		}

		/// <summary>
		/// Khởi tạo cấu hình quyền Windows
		/// </summary>
		/// <param name="serverName"></param>
		/// <param name="databaseName"></param>
		/// <param name="windowsAuthentication"></param>
		public Config(string serverName, string databaseName, bool windowsAuthentication)
		{
			this.serverName = serverName;
			this.databaseName = databaseName;
			this.windowsAuthentication = windowsAuthentication;
		}

		/// <summary>
		/// Khởi tạo cấu hình quyền SQL Server
		/// </summary>
		/// <param name="serverName"></param>
		/// <param name="databaseName"></param>
		/// <param name="windowsAuthentication"></param>
		/// <param name="username"></param>
		/// <param name="password"></param>
		public Config(string serverName, string databaseName, bool windowsAuthentication, string username, string password)
		{
			this.serverName = serverName;
			this.databaseName = databaseName;
			this.windowsAuthentication = windowsAuthentication;
			this.username = username;
			this.password = password;
		}
		#region Properties
		public string ServerName
		{
			get { return serverName; }
			set { serverName = value; }
		}

		public string DatabaseName
		{
			get { return databaseName; }
			set { databaseName = value; }
		}

		public bool WindowsAuthentication
		{
			get { return windowsAuthentication; }
			set { windowsAuthentication = value; }
		}

		public string Username
		{
			get { return username; }
			set { username = value; }
		}

		public string Password
		{
			get { return password; }
			set { password = value; }
		}
		#endregion
	}
}
