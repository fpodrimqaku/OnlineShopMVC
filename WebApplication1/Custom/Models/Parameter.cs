namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Parameter
    {
        public int ID { get; set; }

        [Required]
        [StringLength(250)]
        public string TitleSQ { get; set; }

        [Required]
        [StringLength(250)]
        public string TitleSR { get; set; }

        [Required]
        [StringLength(250)]
        public string TitleEN { get; set; }

        public bool Active { get; set; }

        public bool? IsDeleted { get; set; }

        public int IDEntryUser { get; set; }

        public DateTime EntryDate { get; set; }
    }
}
