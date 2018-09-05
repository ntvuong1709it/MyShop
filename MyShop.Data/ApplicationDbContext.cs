using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyShop.Data.Entities;
using MyShop.Data.Interfaces;

namespace MyShop.Data
{
    public class ApplicationDbContext :IdentityDbContext<AppUser>, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>()
                .HasOne(p => p.Wallet)
                .WithOne(i => i.Customer)
                .HasForeignKey<Wallet>(b => b.CustomerId)
                .HasPrincipalKey<Customer>(c => c.IdentityId);

            modelBuilder.Entity<Wallet>()
                .HasAlternateKey(w => w.Guid)
                .HasName("Unique_Guid");

            modelBuilder.Entity<ProductCategory>()
                .HasKey(p => new { p.CategoryId, p.ProductId });

            modelBuilder.Entity<Product>()
                .Property(p => p.Status)
                .HasDefaultValue("Pushlish");
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
