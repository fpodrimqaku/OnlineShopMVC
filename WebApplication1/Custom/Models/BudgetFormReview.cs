namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BudgetFormReview")]
    public partial class BudgetFormReview
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BudgetFormReview()
        {
            BudgetReviews = new HashSet<BudgetReview>();
            StaffDetailsReviews = new HashSet<StaffDetailsReview>();
        }

        public int ID { get; set; }

        public int IDEntryUser { get; set; }

        public DateTime EntryDate { get; set; }

        public int BaseYear { get; set; }

        public bool Final { get; set; }

        public int VersionNr { get; set; }

        public bool? IsCentral { get; set; }

        public DateTime DateReceive { get; set; }

        [Required]
        [StringLength(250)]
        public string Description { get; set; }

        [StringLength(250)]
        public string CloseDescription { get; set; }

        public bool? IsClosed { get; set; }

        public DateTime? ClosedDate { get; set; }

        public int IDBudgetFormInherited { get; set; }

        public virtual BudgetFormExecute BudgetFormExecute { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BudgetReview> BudgetReviews { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffDetailsReview> StaffDetailsReviews { get; set; }
    }
}
