namespace DTO.Domain
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity.Spatial;

	public partial class Room
	{
		public Room()
		{
			BookingDetails = new HashSet<BookingDetail>();
			CheckInDetails = new HashSet<CheckInDetail>();
		}

		[StringLength(10)]
		public string RoomId { get; set; }

		[StringLength(10)]
		public string TypeId { get; set; }

		public virtual ICollection<BookingDetail> BookingDetails { get; set; }

		public virtual ICollection<CheckInDetail> CheckInDetails { get; set; }

		public virtual RoomType RoomType { get; set; }
	}
}
