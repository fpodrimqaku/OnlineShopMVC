namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WageClass")]
    public partial class WageClass
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string TitleSQ { get; set; }

        [StringLength(50)]
        public string TitleSR { get; set; }

        [StringLength(50)]
        public string TitleEN { get; set; }
    }
}
