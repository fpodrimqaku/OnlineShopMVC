namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person")]
    public partial class Person
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string First { get; set; }

        [Required]
        [StringLength(50)]
        public string Last { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        public DateTime InsertionDate { get; set; }

        [StringLength(100)]
        public string Image { get; set; }
    }
}
