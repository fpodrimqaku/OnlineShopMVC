namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrganisationSector")]
    public partial class OrganisationSector
    {
        public int ID { get; set; }

        public int? IDParent { get; set; }

        [Required]
        [StringLength(20)]
        public string Code { get; set; }

        [Required]
        [StringLength(150)]
        public string TitleSQ { get; set; }

        [Required]
        [StringLength(150)]
        public string TitleSR { get; set; }

        [Required]
        [StringLength(150)]
        public string TitleEN { get; set; }

        public bool Active { get; set; }

        public bool IsDeleted { get; set; }

        public int IDEntryUser { get; set; }

        public DateTime EntryDate { get; set; }

        public virtual User User { get; set; }
    }
}
