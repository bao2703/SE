namespace DTO
{
	using System;
	using System.Collections.Generic;

	public class CheckInDetailDTO
	{
		public CheckInDetailDTO()
		{
		}

		public string CheckInId { get; set; }

		public string RoomId { get; set; }

		public DateTime CheckInDate { get; set; }

		public DateTime CheckOutDate { get; set; }

		public int NumOfCustomer { get; set; }

		public decimal RoomPrice { get; set; }

		public virtual RoomDTO Room { get; set; }
	}
}
