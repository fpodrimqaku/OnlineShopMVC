namespace WebApplication1.Custom.Models.Shop
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Shop : DbContext
    {
        public Shop()
            : base("name=Shop")
        {
        }

        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Receipts)
                .WithOptional(e => e.Customer1)
                .HasForeignKey(e => e.Customer);

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.CartItems)
                .WithOptional(e => e.Product1)
                .HasForeignKey(e => e.Product);

            modelBuilder.Entity<Receipt>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Receipt>()
                .HasMany(e => e.CartItems)
                .WithOptional(e => e.Receipt1)
                .HasForeignKey(e => e.Receipt);
        }
    }
}
