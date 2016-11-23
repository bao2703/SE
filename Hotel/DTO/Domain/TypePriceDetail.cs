namespace DTO.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TypePriceDetail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string TypePriceId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string TypeId { get; set; }

        public int NumOfCustomer { get; set; }

        public virtual RoomType RoomType { get; set; }

        public virtual TypePrice TypePrice { get; set; }
    }
}
