namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RequestBudgetTransfer")]
    public partial class RequestBudgetTransfer
    {
        public int ID { get; set; }

        public int IDTransfer { get; set; }

        public int IDTransferPercentage { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public int? IDAnalystUser { get; set; }

        public bool? AnalystApproved { get; set; }

        [StringLength(250)]
        public string AnalystDescription { get; set; }

        public int? IDLeadUser { get; set; }

        [StringLength(250)]
        public string LeadDescription { get; set; }

        public bool? LeadApproved { get; set; }

        public DateTime EntryDate { get; set; }

        public int IDEntryUser { get; set; }

        public virtual BudgetTransfer BudgetTransfer { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual User User2 { get; set; }
    }
}
