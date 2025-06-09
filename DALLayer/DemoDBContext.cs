using DALLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLayer
{
    public class DemoDBContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PurchaseDetail> PurchaseDetails { get; set; }
        public DbSet<CardDetail> CardDetails { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build()
                    .GetConnectionString("DemoDBConnectionString"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                        .HasIndex(c => c.CategoryName)
                        .IsUnique();

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(p => p.ProductName)
                .IsUnique();
            });

            modelBuilder.Entity<Role>()
                            .HasIndex(r => r.RoleName)
                            .IsUnique();

            modelBuilder.Entity<PurchaseDetail>()
                            .HasIndex(pd => new { pd.EmailId ,pd.ProductId })
                            .IsUnique();

            modelBuilder.Entity<CardDetail>(entity =>
                { 
                    entity.HasIndex(cd => cd.CardNumber)
                    .IsUnique();
                    entity.Property(cd => cd.ExpiryDate)
                    .HasDefaultValueSql("GETDATE()");
                });
        }


    }
}
