namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class StaffDetail
    {
        public int ID { get; set; }

        public int BaseYear { get; set; }

        public int IDOrganisation { get; set; }

        public int IDWageCoefficients { get; set; }

        public int NumberOfStaff { get; set; }

        public int NumberOfStaffProjectionI { get; set; }

        public int NumberOfStaffProjectionII { get; set; }

        public decimal Total { get; set; }

        public decimal TotalProjectionI { get; set; }

        public decimal TotalProjectionII { get; set; }

        public int IDBudgetForm { get; set; }

        public int IDEntryUser { get; set; }

        public DateTime EntryDate { get; set; }

        public virtual BudgetForm BudgetForm { get; set; }

        public virtual User User { get; set; }

        public virtual WageCoefficient WageCoefficient { get; set; }
    }
}
