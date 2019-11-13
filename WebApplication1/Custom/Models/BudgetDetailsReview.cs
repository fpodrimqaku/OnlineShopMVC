namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BudgetDetailsReview")]
    public partial class BudgetDetailsReview
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BudgetDetailsReview()
        {
            FundingDetailsReviews = new HashSet<FundingDetailsReview>();
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

        public virtual BudgetReview BudgetReview { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FundingDetailsReview> FundingDetailsReviews { get; set; }
    }
}
