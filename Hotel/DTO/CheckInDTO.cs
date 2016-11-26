namespace DTO
{
	using System;
	using System.Collections.Generic;

	public class CheckInDTO
	{
		public CheckInDTO()
		{ 
		}

		public static string PrefixId
		{
			get
			{
				return "I";
			}
		}

		public string CheckInId { get; set; }

		public string CustomerId { get; set; }

		public string EmployeeId { get; set; }

		public string BookingId { get; set; }

		public DateTime CreatedDate { get; set; }

		public int TotalRoom
		{
			get
			{
				return CheckInDetails.Count;
			}
		}

		public CustomerDTO Customer { get; set; }

		public List<CheckInDetailDTO> CheckInDetails { get; set; }
	}
}
