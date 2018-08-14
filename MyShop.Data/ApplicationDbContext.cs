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
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}
