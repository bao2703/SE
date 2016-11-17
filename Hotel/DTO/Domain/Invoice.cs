namespace DTO.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Invoice
    {
        [StringLength(10)]
        public string InvoiceId { get; set; }

        [Required]
        [StringLength(10)]
        public string CheckInId { get; set; }

        [Required]
        [StringLength(10)]
        public string EmployeeId { get; set; }

        public DateTime CreatedDate { get; set; }

        public decimal TotalPrice { get; set; }

        public virtual CheckIn CheckIn { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
