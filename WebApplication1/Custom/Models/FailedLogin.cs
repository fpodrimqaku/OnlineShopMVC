namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FailedLogin
    {
        public int Id { get; set; }

        public DateTime InsertionDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string ComputerName { get; set; }

        [StringLength(50)]
        public string IPAddress { get; set; }

        [Required]
        [StringLength(500)]
        public string BrowserType { get; set; }

        public bool IsMobileDevice { get; set; }
    }
}
