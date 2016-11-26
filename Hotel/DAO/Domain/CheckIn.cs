namespace DAO.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CheckIn
    {
        public CheckIn()
        {
			this.CheckInDetails = new HashSet<CheckInDetail>();
			this.Invoices = new HashSet<Invoice>();
			this.ServiceDetails = new HashSet<ServiceDetail>();
        }

        [StringLength(10)]
        public string CheckInId { get; set; }

        [Required]
        [StringLength(10)]
        public string CustomerId { get; set; }

        [Required]
        [StringLength(10)]
        public string EmployeeId { get; set; }

        [StringLength(10)]
        public string BookingId { get; set; }

        public DateTime? CreatedDate { get; set; }

        public virtual Booking Booking { get; set; }

        public virtual ICollection<CheckInDetail> CheckInDetails { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }

        public virtual ICollection<ServiceDetail> ServiceDetails { get; set; }
    }
}
