namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SystemStatu
    {
        public int ID { get; set; }

        public int BaseYear { get; set; }

        public int IDStatusProcess { get; set; }

        public bool? IsCentral { get; set; }

        public bool IsClosed { get; set; }

        public int? IDOrganisation { get; set; }

        public int IDEntryUser { get; set; }

        public DateTime InsertionDate { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }

        public bool IsDeleted { get; set; }

        public virtual Organisation Organisation { get; set; }

        public virtual User User { get; set; }
    }
}
