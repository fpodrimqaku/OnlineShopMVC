namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BudgetExecute")]
    public partial class BudgetExecute
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BudgetExecute()
        {
            BudgetDetailsExecutes = new HashSet<BudgetDetailsExecute>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string BudgetCode { get; set; }

        public int BaseYear { get; set; }

        public int IDOrganisation { get; set; }

        public int IDEconomicCategory { get; set; }

        public decimal Amount { get; set; }

        public decimal AmountProjectionI { get; set; }

        public decimal AmountProjectionII { get; set; }

        [Required]
        [StringLength(250)]
        public string Description { get; set; }

        public int? EntryUserID { get; set; }

        public DateTime EntryDate { get; set; }

        public int IDBudgetForm { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BudgetDetailsExecute> BudgetDetailsExecutes { get; set; }

        public virtual BudgetFormExecute BudgetFormExecute { get; set; }
    }
}
