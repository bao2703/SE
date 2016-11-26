namespace DTO
{
	using System;
	using System.Collections.Generic;

	public class BookingDTO
	{
		public BookingDTO()
		{
		}

		public static string PrefixId
		{
			get
			{
				return "B";
			}
		}

		public string BookingId { get; set; }

		public string CustomerId { get; set; }

		public string EmployeeId { get; set; }

		public DateTime CreatedDate { get; set; }

		public CustomerDTO Customer { get; set; }

		public List<BookingDetailDTO> BookingDetails { get; set; }
	}
}
