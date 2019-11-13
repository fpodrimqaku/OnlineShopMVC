namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BudgetTotal")]
    public partial class BudgetTotal
    {
        public int ID { get; set; }

        public int BaseYear { get; set; }

        public decimal Amount { get; set; }

        public int EntryUserID { get; set; }

        public DateTime EntryDate { get; set; }
    }
}
