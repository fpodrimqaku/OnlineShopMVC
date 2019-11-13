namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BudgetForm")]
    public partial class BudgetForm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BudgetForm()
        {
            Budgets = new HashSet<Budget>();
            BudgetFormExecutes = new HashSet<BudgetFormExecute>();
            Fundings = new HashSet<Funding>();
            Staffs = new HashSet<Staff>();
            StaffDetails = new HashSet<StaffDetail>();
        }

        public int ID { get; set; }

        public int IDEntryUser { get; set; }

        public DateTime EntryDate { get; set; }

        public int BaseYear { get; set; }

        public bool Final { get; set; }

        public int VersionNr { get; set; }

        public bool IsCentral { get; set; }

        public DateTime DateReceive { get; set; }

        [Required]
        [StringLength(250)]
        public string Description { get; set; }

        [StringLength(250)]
        public string CloseDescription { get; set; }

        public bool? IsClosed { get; set; }

        public DateTime? ClosedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Budget> Budgets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BudgetFormExecute> BudgetFormExecutes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Funding> Fundings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Staff> Staffs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffDetail> StaffDetails { get; set; }
    }
}
