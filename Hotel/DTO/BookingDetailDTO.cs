namespace DTO
{
	using System;
	using System.Collections.Generic;

	public class BookingDetailDTO
	{
		public string BookingId { get; set; }

		public string RoomId { get; set; }

		public DateTime BookingStart { get; set; }

		public DateTime BookingEnd { get; set; }

		public int NumOfCustomer { get; set; }

		public RoomDTO Room { get; set; }
	}
}
