namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserHistory")]
    public partial class UserHistory
    {
        public int Id { get; set; }

        public int IdUser { get; set; }

        public bool TypeAction { get; set; }

        public DateTime InsertionDate { get; set; }

        [StringLength(50)]
        public string ComputerName { get; set; }

        [StringLength(50)]
        public string IPAddress { get; set; }

        [Required]
        [StringLength(250)]
        public string BrowserType { get; set; }

        public bool IsMobileDevice { get; set; }

        public int? IdOperationSystemType { get; set; }

        [StringLength(400)]
        public string BrowserAndUserAgentType { get; set; }

        public virtual OperationSystemType OperationSystemType { get; set; }

        public virtual User User { get; set; }
    }
}
