namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ParameterCalculation
    {
        public int ID { get; set; }

        public int IDParameter { get; set; }

        public decimal Value { get; set; }

        public bool Active { get; set; }

        public int IDEntryUser { get; set; }

        public DateTime EntryDate { get; set; }

        public int? BaseYear { get; set; }

        public virtual ParameterCalculation ParameterCalculations1 { get; set; }

        public virtual ParameterCalculation ParameterCalculation1 { get; set; }
    }
}
