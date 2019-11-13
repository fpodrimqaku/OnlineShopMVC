namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RolePIP")]
    public partial class RolePIP
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string TitleSQ { get; set; }

        [Required]
        [StringLength(200)]
        public string TitleEN { get; set; }

        [Required]
        [StringLength(200)]
        public string TitleSR { get; set; }
    }
}
