namespace DTO.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CheckIn")]
    public partial class CheckIn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CheckIn()
        {
            CheckInDetails = new HashSet<CheckInDetail>();
            Invoices = new HashSet<Invoice>();
            ServiceDetails = new HashSet<ServiceDetail>();
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

        public virtual Customer Customer { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CheckInDetail> CheckInDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceDetail> ServiceDetails { get; set; }
    }
}
