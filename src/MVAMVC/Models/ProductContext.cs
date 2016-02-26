using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVAMVC.Models
{
    public class ProductContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(c => c.CategoryId)
                .IsRequired()
                .HasColumnName("CategoryID");

            modelBuilder.Entity<Product>()
                .Property(c => c.ProductId)
                .IsRequired()
                .HasColumnName("ProductID");
        }
    }
}
