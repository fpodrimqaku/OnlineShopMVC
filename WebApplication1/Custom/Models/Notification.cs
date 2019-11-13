namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Notification")]
    public partial class Notification
    {
        public int Id { get; set; }

        public int IdNotificationType { get; set; }

        public int IdEntryUser { get; set; }

        public DateTime InsertionDate { get; set; }

        [Required]
        [StringLength(400)]
        public string Value { get; set; }

        public bool IsRead { get; set; }

        public int? IdUserRead { get; set; }

        public DateTime? ReadDate { get; set; }

        public virtual NotificationType NotificationType { get; set; }

        public virtual User User { get; set; }
    }
}
