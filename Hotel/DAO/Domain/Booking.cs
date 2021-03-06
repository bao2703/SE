namespace DAO.Domain
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity.Spatial;

	public partial class Booking
	{
		public Booking()
		{
			this.BookingDetails = new HashSet<BookingDetail>();
			this.CheckIns = new HashSet<CheckIn>();
		}

		[StringLength(10)]
		public string BookingId { get; set; }

		[StringLength(10)]
		public string CustomerId { get; set; }

		[StringLength(10)]
		public string EmployeeId { get; set; }

		public DateTime CreatedDate { get; set; }

		public virtual ICollection<BookingDetail> BookingDetails { get; set; }

		public virtual Customer Customer { get; set; }

		public virtual Employee Employee { get; set; }

		public virtual ICollection<CheckIn> CheckIns { get; set; }
	}
}
