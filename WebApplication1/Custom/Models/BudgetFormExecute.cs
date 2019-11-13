namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BudgetFormExecute")]
    public partial class BudgetFormExecute
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BudgetFormExecute()
        {
            BudgetExecutes = new HashSet<BudgetExecute>();
            BudgetFormReviews = new HashSet<BudgetFormReview>();
            BudgetTransfers = new HashSet<BudgetTransfer>();
            StaffDetailsExecutes = new HashSet<StaffDetailsExecute>();
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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BudgetExecute> BudgetExecutes { get; set; }

        public virtual BudgetForm BudgetForm { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BudgetFormReview> BudgetFormReviews { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BudgetTransfer> BudgetTransfers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffDetailsExecute> StaffDetailsExecutes { get; set; }
    }
}
