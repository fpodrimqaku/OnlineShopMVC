namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BudgetTransfer")]
    public partial class BudgetTransfer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BudgetTransfer()
        {
            RequestBudgetTransfers = new HashSet<RequestBudgetTransfer>();
        }

        public int ID { get; set; }

        public int IDOrganisationFrom { get; set; }

        public int IDOrganisationTo { get; set; }

        public int IDEconomicCategoryFrom { get; set; }

        public int IDEconomicCategoryTo { get; set; }

        public decimal Amount { get; set; }

        public decimal? TransferPercentage { get; set; }

        public int IDEntryUser { get; set; }

        public DateTime EntryDate { get; set; }

        public int IDFundSourcesFrom { get; set; }

        public int IDFundSourcesTo { get; set; }

        public int IDTransferStatus { get; set; }

        public int IDBudgetForm { get; set; }

        public decimal CurrentAmountFrom { get; set; }

        public decimal CurrentAmountTo { get; set; }

        public virtual BudgetFormExecute BudgetFormExecute { get; set; }

        public virtual BudgetTransferStatu BudgetTransferStatu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestBudgetTransfer> RequestBudgetTransfers { get; set; }
    }
}
