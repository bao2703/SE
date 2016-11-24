namespace DAO.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Report
    {
        [StringLength(10)]
        public string ReportId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
