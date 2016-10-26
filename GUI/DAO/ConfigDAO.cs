using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DTO;

namespace DAO
{
	public static class ConfigDAO
	{
		/// <summary>
		/// Sửa ConnectionString
		/// </summary>
		/// <param name="connectionString"></param>
		public static void ChangeConnectionString(string connectionString)
		{
			Configuration conf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			conf.ConnectionStrings.ConnectionStrings["ConnectionString"].ConnectionString = connectionString;
			conf.Save(ConfigurationSaveMode.Modified);
			ConfigurationManager.RefreshSection(conf.ConnectionStrings.SectionInformation.Name);
			Properties.Settings.Default.Reload();
		}

		public static void SetAppConfig(Config config)
		{
			Configuration conf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			conf.AppSettings.Settings["Server"].Value = config.ServerName;
			conf.AppSettings.Settings["Database"].Value = config.DatabaseName;
			conf.AppSettings.Settings["WindowsAuthentication"].Value = config.WindowsAuthentication.ToString();
			conf.AppSettings.Settings["Username"].Value = config.Username;
			conf.AppSettings.Settings["Password"].Value = config.Password;

			conf.Save(ConfigurationSaveMode.Modified);
			ConfigurationManager.RefreshSection("appSettings");
		}

		public static Config GetAppConfig()
		{
			Config config = new Config();
			Configuration conf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			config.ServerName = conf.AppSettings.Settings["Server"].Value;
			config.DatabaseName = conf.AppSettings.Settings["Database"].Value;
			if (conf.AppSettings.Settings["WindowsAuthentication"].Value == "True")
			{
				config.WindowsAuthentication = true;
			}
			else
			{
				config.WindowsAuthentication = false;
			}
			config.Username = conf.AppSettings.Settings["Username"].Value;
			config.Password = conf.AppSettings.Settings["Password"].Value;
			return config;
		}
	}
}
