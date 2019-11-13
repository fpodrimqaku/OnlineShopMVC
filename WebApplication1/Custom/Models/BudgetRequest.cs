namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BudgetRequest")]
    public partial class BudgetRequest
    {
        public int ID { get; set; }

        public int IDBudget { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public decimal Amount { get; set; }

        public decimal AmountProjectionI { get; set; }

        public decimal AmountProjectionII { get; set; }

        public int EntryUserID { get; set; }

        public DateTime EntryDate { get; set; }

        public virtual Budget Budget { get; set; }

        public virtual User User { get; set; }
    }
}
