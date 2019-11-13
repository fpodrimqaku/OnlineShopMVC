namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Constant")]
    public partial class Constant
    {
        public int Id { get; set; }

        public int IdConstantGroup { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(1000)]
        public string Content { get; set; }

        [StringLength(1000)]
        public string ContentEN { get; set; }

        [StringLength(1000)]
        public string ContentSR { get; set; }

        public virtual ConstantGroup ConstantGroup { get; set; }
    }
}
