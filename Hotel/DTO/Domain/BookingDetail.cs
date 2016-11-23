namespace DTO.Domain
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity.Spatial;

	public partial class BookingDetail
	{
		[Key]
		[Column(Order = 0)]
		[StringLength(10)]
		public string BookingId { get; set; }

		[Key]
		[Column(Order = 1)]
		[StringLength(10)]
		public string RoomId { get; set; }

		public DateTime BookingStart { get; set; }

		public DateTime BookingEnd { get; set; }

		public int NumOfCustomer { get; set; }

		public virtual Booking Booking { get; set; }

		public virtual Room Room { get; set; }
	}
}
