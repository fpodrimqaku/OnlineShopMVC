namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Center
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Center()
        {
            Users = new HashSet<User>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(150)]
        public string TitleSQ { get; set; }

        [Required]
        [StringLength(150)]
        public string TitleEN { get; set; }

        [Required]
        [StringLength(150)]
        public string TitleSR { get; set; }

        public int IDEntryUser { get; set; }

        public DateTime EntryDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}
