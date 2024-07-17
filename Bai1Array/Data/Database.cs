using Bai1Array.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1Array.Data
{
    public class Database
    {
        public Product[] Products { get; set; }
        public Category[] Categories { get; set; }

        public Database()
        {
            Products = new Product[] { };
            Categories = new Category[] { };
        }

        public void Initialize()
        {
            Products = new Product[]
            {
                new Product { Id = 1, Name = "Product 1", Price = 500, Quantity = 20, CategoryId = 1 },
                new Product { Id = 2, Name = "Product 2", Price = 200, Quantity = 10, CategoryId = 2 },
                new Product { Id = 3, Name = "Product 3", Price = 400, Quantity = 40, CategoryId = 3 },
                new Product { Id = 4, Name = "Product 4", Price = 300, Quantity = 90, CategoryId = 4 },
                new Product { Id = 5, Name = "Product 5", Price = 100, Quantity = 60, CategoryId = 5 },
                new Product { Id = 6, Name = "Product 6", Price = 600, Quantity = 80, CategoryId = 1 },
                new Product { Id = 7, Name = "Product 7", Price = 200, Quantity = 70, CategoryId = 2 },
                new Product { Id = 8, Name = "Product 8", Price = 1000, Quantity = 50, CategoryId = 3 },
                new Product { Id = 9, Name = "Product 9", Price = 900, Quantity = 90, CategoryId = 4 },
                new Product { Id = 10, Name = "Product 10", Price = 800, Quantity = 100, CategoryId = 5 }
            };

            Categories = new Category[]
            {
                new Category { Id = 1, Name = "Category 1" },
                new Category { Id = 2, Name = "Category 2" },
                new Category { Id = 3, Name = "Category 3" },
                new Category { Id = 4, Name = "Category 4" },
                new Category { Id = 5, Name = "Category 5" }
            };
        }
    }
}
