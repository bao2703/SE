using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DAO
{
	public class ConfigDAO
	{
		public static void ChangeConnectionString(string connectionString)
		{
			Configuration conf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			conf.ConnectionStrings.ConnectionStrings["HotelContext"].ConnectionString = connectionString;
			conf.Save(ConfigurationSaveMode.Modified);
			ConfigurationManager.RefreshSection(conf.ConnectionStrings.SectionInformation.Name);
		}
	}
}
