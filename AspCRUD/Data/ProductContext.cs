using AspCRUD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspCRUD.Data
{
    public class ProductContext:DbContext
    {
        public ProductContext():base("ProductContext")
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
            .Property(b => b.Price).HasPrecision(18,2);
        }
    }
}