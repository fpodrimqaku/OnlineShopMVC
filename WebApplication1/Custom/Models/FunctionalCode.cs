namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FunctionalCode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FunctionalCode()
        {
            Organisations = new HashSet<Organisation>();
        }

        public int ID { get; set; }

        public int? IDParent { get; set; }

        [Required]
        [StringLength(20)]
        public string Code { get; set; }

        [Required]
        [StringLength(300)]
        public string TitleSQ { get; set; }

        [Required]
        [StringLength(300)]
        public string TitleSR { get; set; }

        [Required]
        [StringLength(300)]
        public string TitleEN { get; set; }

        public bool Active { get; set; }

        public bool IsDeleted { get; set; }

        public int IDEntryUser { get; set; }

        public DateTime EntryDate { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Organisation> Organisations { get; set; }
    }
}
