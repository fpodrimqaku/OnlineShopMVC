namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BudgetParameterBoundary
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(150)]
        public string TitleSQ { get; set; }

        [Required]
        [StringLength(150)]
        public string TitleEN { get; set; }

        [Required]
        [StringLength(150)]
        public string TitleSR { get; set; }
    }
}
