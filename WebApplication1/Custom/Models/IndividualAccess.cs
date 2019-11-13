namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IndividualAccess")]
    public partial class IndividualAccess
    {
        public int Id { get; set; }

        public int IdUser { get; set; }

        public int IdAccessType { get; set; }

        public int IdView { get; set; }

        public DateTime InsertionDate { get; set; }

        public virtual AccessType AccessType { get; set; }

        public virtual User User { get; set; }

        public virtual View View { get; set; }
    }
}
