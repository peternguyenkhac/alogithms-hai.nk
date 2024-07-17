using Bai1Array.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1Array.Util
{
    public static class PrintProduct
    {
        public static void Print(this Product product)
        {
            Console.WriteLine($"Product Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity} ,Category: {product.CategoryId}");
        }

        public static void Print(this List<Product> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine($"Product Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity} ,Category: {product.CategoryId}");
            }
        }

        public static void Print(this Dictionary<Product, Category?> productCategoryMap)
        {
            foreach (var keyValue in productCategoryMap)
            {
                Console.WriteLine($"Product Id: {keyValue.Key.Id}, Name: {keyValue.Key.Name}, Price: {keyValue.Key.Price}, Quantity: {keyValue.Key.Quantity}, Category name: {keyValue.Value?.Name ?? "null"}");
            }
        }
    }
}
