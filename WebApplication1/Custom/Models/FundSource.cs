namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FundSource
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FundSource()
        {
            Fundings = new HashSet<Funding>();
        }

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
        public string TitleEN { get; set; }

        [Required]
        [StringLength(150)]
        public string TitleSR { get; set; }

        public bool Active { get; set; }

        public bool IsDeleted { get; set; }

        public int IDEntryUser { get; set; }

        public DateTime EntryDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Funding> Fundings { get; set; }

        public virtual User User { get; set; }
    }
}
