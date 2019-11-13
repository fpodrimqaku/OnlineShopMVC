namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Organisation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Organisation()
        {
            Budgets = new HashSet<Budget>();
            BudgetDetails = new HashSet<BudgetDetail>();
            Fundings = new HashSet<Funding>();
            SystemStatus = new HashSet<SystemStatu>();
        }

        public int ID { get; set; }

        public int? IDParent { get; set; }

        [Required]
        [StringLength(20)]
        public string Code { get; set; }

        [StringLength(20)]
        public string OldCode { get; set; }

        public int IDOrganisationLevel { get; set; }

        [Required]
        [StringLength(250)]
        public string TitleSQ { get; set; }

        [Required]
        [StringLength(250)]
        public string TitleSR { get; set; }

        [Required]
        [StringLength(250)]
        public string TitleEN { get; set; }

        public int? IDFunctionalCode { get; set; }

        public int? IDOrganisationGroup { get; set; }

        public bool IsCentral { get; set; }

        public int IDCenter { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        public bool IsDeleted { get; set; }

        public bool Active { get; set; }

        public int IDEntryUser { get; set; }

        public DateTime EntryDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Budget> Budgets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BudgetDetail> BudgetDetails { get; set; }

        public virtual FunctionalCode FunctionalCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Funding> Fundings { get; set; }

        public virtual OrganisationLevel OrganisationLevel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SystemStatu> SystemStatus { get; set; }
    }
}
