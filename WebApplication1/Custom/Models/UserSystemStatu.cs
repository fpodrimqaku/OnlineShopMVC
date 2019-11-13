namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserSystemStatu
    {
        public int ID { get; set; }

        public int BaseYear { get; set; }

        public int IDStatusProcess { get; set; }

        public bool IsCentral { get; set; }

        public bool IsClosed { get; set; }

        public int IDUser { get; set; }

        public int IDEntryUser { get; set; }

        public DateTime InsertionDate { get; set; }

        public bool IsDeleted { get; set; }
    }
}
