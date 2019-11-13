namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FundingDetail
    {
        public int ID { get; set; }

        public int IDBudgetDetails { get; set; }

        public int IDFundSources { get; set; }

        public decimal Amount { get; set; }

        public decimal AmountProjectionI { get; set; }

        public decimal AmountProjectionII { get; set; }

        public int EntryUserID { get; set; }

        public DateTime EntryDate { get; set; }

        public int? IDFunding { get; set; }

        public virtual BudgetDetail BudgetDetail { get; set; }
    }
}
