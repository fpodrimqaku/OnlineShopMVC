namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChangeLog")]
    public partial class ChangeLog
    {
        public int Id { get; set; }

        public short IdTable { get; set; }

        public int IdEntryUser { get; set; }

        public DateTime InsertionDate { get; set; }

        [Required]
        public byte[] Before { get; set; }

        public byte[] After { get; set; }

        public bool IsEdit { get; set; }

        public virtual Table Table { get; set; }

        public virtual User User { get; set; }
    }
}
