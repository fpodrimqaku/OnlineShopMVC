namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hierarchy")]
    public partial class Hierarchy
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string OrderPosition { get; set; }

        public int? IDParent { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public int IDEntryUser { get; set; }

        public DateTime InsertionDate { get; set; }
    }
}
