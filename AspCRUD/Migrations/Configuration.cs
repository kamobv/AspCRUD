namespace AspCRUD.Migrations
{
    using AspCRUD.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AspCRUD.Data.ProductContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
        protected override void Seed(AspCRUD.Data.ProductContext context)
        {
            if (!context.Products.Any())
            {
                Category category1 = new Category
                {
                     Name = "Erzaq"
                };
                Category category2 = new Category
                {
                    Name = "Sirniyyat"
                };
                Category category3 = new Category
                {
                    Name = "Terevez"
                };

                var productList1 = new List<Product>
                {
                    new Product{ Name = "Qend", Quantity = 100, Price = 1.2m},
                    new Product{ Name = "Cay", Quantity = 50, Price = 2m},
                    new Product{ Name = "Qend", Quantity = 100, Price = 1.2m},
                };

                var productList2 = new List<Product>
                {
                    new Product{ Name = "Snikers", Quantity = 40, Price = 1.8m},
                    new Product{ Name = "Kek", Quantity = 15, Price = 2m},
                };

                var productList3 = new List<Product>
                {
                    new Product{ Name = "Xiyar", Quantity = 20, Price = 0.5m},
                    new Product{ Name = "Pomidor", Quantity = 15, Price = 1.5m},
                    new Product{ Name = "Istiot", Quantity = 15, Price = 0.7m},
                };

                category1.Products.AddRange(productList1);
                category2.Products.AddRange(productList2);
                category3.Products.AddRange(productList3);

                context.Categories.Add(category1);
                context.Categories.Add(category2);
                context.Categories.Add(category3);

                context.SaveChanges();
            }
        }
    }
}
