namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BudgetDetailsExecute")]
    public partial class BudgetDetailsExecute
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BudgetDetailsExecute()
        {
            FundingDetailsExecutes = new HashSet<FundingDetailsExecute>();
        }

        public int ID { get; set; }

        public int IDBudget { get; set; }

        public decimal Amount { get; set; }

        public decimal AmountProjectionI { get; set; }

        public decimal AmountProjectionII { get; set; }

        public int IDEconomicCategory { get; set; }

        public int IDOrganisation { get; set; }

        public int EntryUserID { get; set; }

        public DateTime EntryDate { get; set; }

        public virtual BudgetExecute BudgetExecute { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FundingDetailsExecute> FundingDetailsExecutes { get; set; }
    }
}
