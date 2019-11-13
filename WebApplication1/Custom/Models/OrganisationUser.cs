namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrganisationUser")]
    public partial class OrganisationUser
    {
        public int ID { get; set; }

        public int IDOrganisation { get; set; }

        public int IDUser { get; set; }

        public int EntryUserID { get; set; }

        public DateTime EntryDate { get; set; }

        public virtual User User { get; set; }
    }
}
