namespace DTO.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RoomType
    {
        public RoomType()
        {
            RoomPriceDetails = new HashSet<RoomPriceDetail>();
            Rooms = new HashSet<Room>();
        }

        [Key]
        [StringLength(10)]
        public string TypeId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<RoomPriceDetail> RoomPriceDetails { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}
