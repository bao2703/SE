namespace DTO
{
	using System;
	using System.Collections.Generic;

	public class CustomerDTO
	{
		public CustomerDTO()
		{
		}

		public static string PrefixId
		{
			get
			{
				return "C";
			}
		}

		public string CustomerId { get; set; }

		public string Name { get; set; }

		public string Address { get; set; }

		public string Phone { get; set; }

		public string Fax { get; set; }

		public string Telex { get; set; }
	}
}
