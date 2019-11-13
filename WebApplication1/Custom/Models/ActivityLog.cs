namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ActivityLog")]
    public partial class ActivityLog
    {
        public long Id { get; set; }

        public int IdActivityLogType { get; set; }

        public int IdUser { get; set; }

        public int IdView { get; set; }

        public DateTime InsertionDate { get; set; }

        [StringLength(200)]
        public string URL { get; set; }

        public bool? IsMobileDevice { get; set; }

        [StringLength(100)]
        public string BrowserType { get; set; }

        [StringLength(250)]
        public string BrowserAndUserAgentType { get; set; }

        public int? IdOperationSystemType { get; set; }

        public virtual ActivityLogType ActivityLogType { get; set; }

        public virtual User User { get; set; }

        public virtual View View { get; set; }
    }
}
