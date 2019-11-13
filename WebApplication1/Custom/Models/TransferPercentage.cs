namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransferPercentage")]
    public partial class TransferPercentage
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string TitleSQ { get; set; }

        [Required]
        [StringLength(50)]
        public string TitleSR { get; set; }

        [Required]
        [StringLength(50)]
        public string TitleEN { get; set; }
    }
}
