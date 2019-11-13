namespace WebApplication1.Custom.Models.Shop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CartItem")]
    public partial class CartItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? Quantity { get; set; }

        public int? Product { get; set; }

        public int? Receipt { get; set; }

        public virtual Product Product1 { get; set; }

        public virtual Receipt Receipt1 { get; set; }
    }
}
