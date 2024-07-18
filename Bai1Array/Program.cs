using Bai1Array.Data;

namespace Bai1Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();
            database.Initialize();
            ProductService productService = new ProductService(database);

            Console.WriteLine("=== Map product by category ===");
            productService.MapProductByCategory().PrintProductMapWithCategory();

            Console.WriteLine("=== Max price ===");
            productService.MaxByPrice().Print();

            Console.WriteLine("=== Min price ===");
            productService.MinByPrice().Print();

            Console.WriteLine("=== Sort by price ===");
            productService.SortByPrice().Print();

            Console.WriteLine("=== Sort by name lenght ===");
            productService.SortByName().Print();

            Console.WriteLine("=== Sort by category name ===");
            productService.SortByCategoryName().Print();

            Console.WriteLine("=== Find product by name Product 1 ===");
            productService.FindProductByName("Product 1").Print();

            Console.WriteLine("=== Find product by price 300 ===");
            productService.FindProductByPrice(300).Print();

            Console.WriteLine("=== Find product by category 2 ===");
            productService.FindProductByCategory(2).Print();
        }
    }
}
