namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoleAccess")]
    public partial class RoleAccess
    {
        public int Id { get; set; }

        public int IdRole { get; set; }

        public int IdAccessType { get; set; }

        public int IdView { get; set; }

        public DateTime InsertionDate { get; set; }

        public virtual AccessType AccessType { get; set; }

        public virtual Role Role { get; set; }

        public virtual View View { get; set; }
    }
}
