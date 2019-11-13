namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Budget")]
    public partial class Budget
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Budget()
        {
            BudgetDetails = new HashSet<BudgetDetail>();
            BudgetRequests = new HashSet<BudgetRequest>();
        }

        public int ID { get; set; }

        [StringLength(30)]
        public string BudgetCode { get; set; }

        public int BaseYear { get; set; }

        public int IDOrganisation { get; set; }

        public int IDEconomicCategory { get; set; }

        public decimal Amount { get; set; }

        public decimal AmountProjectionI { get; set; }

        public decimal AmountProjectionII { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public int EntryUserID { get; set; }

        public DateTime EntryDate { get; set; }

        public int IDBudgetForm { get; set; }

        public virtual BudgetForm BudgetForm { get; set; }

        public virtual EconomicCategory EconomicCategory { get; set; }

        public virtual Organisation Organisation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BudgetDetail> BudgetDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BudgetRequest> BudgetRequests { get; set; }
    }
}
