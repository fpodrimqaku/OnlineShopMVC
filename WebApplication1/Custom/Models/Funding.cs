namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Funding")]
    public partial class Funding
    {
        public int ID { get; set; }

        public int BaseYear { get; set; }

        public int IDOrganisation { get; set; }

        public int IDFundSource { get; set; }

        public decimal? CarryAmount { get; set; }

        public decimal Amount { get; set; }

        public decimal AmountProjectionI { get; set; }

        public decimal AmountProjectionII { get; set; }

        public int IDEntryUser { get; set; }

        public DateTime EntryDate { get; set; }

        public int IDBudgetForm { get; set; }

        public virtual BudgetForm BudgetForm { get; set; }

        public virtual FundSource FundSource { get; set; }

        public virtual Organisation Organisation { get; set; }

        public virtual User User { get; set; }
    }
}
