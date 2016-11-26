namespace DAO
{
	using System;
	using System.Configuration;

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
