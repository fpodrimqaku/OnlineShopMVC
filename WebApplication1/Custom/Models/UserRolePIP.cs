namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserRolePIP")]
    public partial class UserRolePIP
    {
        public int Id { get; set; }

        public int IdUser { get; set; }

        public int IdRolePIP { get; set; }

        public int EntryUserID { get; set; }

        public DateTime EntryDate { get; set; }
    }
}
