namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FundingPlanned")]
    public partial class FundingPlanned
    {
        public int ID { get; set; }

        public int IDFundSources { get; set; }

        public decimal Amount { get; set; }

        public decimal AmountProjectionI { get; set; }

        public decimal AmountProjectionII { get; set; }

        public int IDOrganisation { get; set; }

        public int IDBudgetForm { get; set; }

        public int IDEntryUser { get; set; }
    }
}
