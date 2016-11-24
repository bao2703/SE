namespace DAO.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee
    {
        public Employee()
        {
            Bookings = new HashSet<Booking>();
            CheckIns = new HashSet<CheckIn>();
            Invoices = new HashSet<Invoice>();
        }

        [StringLength(10)]
        public string EmployeeId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(10)]
        public string Password { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }

        public virtual ICollection<CheckIn> CheckIns { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
