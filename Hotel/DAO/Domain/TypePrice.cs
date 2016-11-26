namespace DAO.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TypePrice
    {
        public TypePrice()
        {
			this.TypePriceDetails = new HashSet<TypePriceDetail>();
        }

        [StringLength(10)]
        public string TypePriceId { get; set; }

        public decimal Price { get; set; }

        public virtual ICollection<TypePriceDetail> TypePriceDetails { get; set; }
    }
}
