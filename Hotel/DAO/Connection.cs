namespace DAO
{
	using System;
	using System.Configuration;

	public class Connection
	{
		public static string ConnectionString
		{
			get
			{
				return ConfigurationManager.ConnectionStrings["HotelContext"].ConnectionString;
			}
		}
	}
}
