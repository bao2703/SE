namespace DTO.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CheckInDetail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string CheckInId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string RoomId { get; set; }

        public decimal RoomPrice { get; set; }

        public int NumOfCustomer { get; set; }

        public DateTime? CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }

        public virtual CheckIn CheckIn { get; set; }

        public virtual Room Room { get; set; }
    }
}
