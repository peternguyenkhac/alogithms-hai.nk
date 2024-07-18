using Bai1Array.Data;
using Bai1Array.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1Array
{
    public class ProductService
    {
        private readonly Database _database;

        public ProductService(Database database)
        {
            _database = database;
        }

        //Tìm kiếm product theo tên
        public Product? FindProductByName(string name)
        {
            foreach (Product product in _database.Products)
            {
                if (product.Name == name)
                {
                    return product;
                }
            }
            return null;
        }

        //Tìm kiếm product theo category Id
        public List<Product> FindProductByCategory(int categoryId)
        {
            List<Product> products = new List<Product>();
            foreach (Product product in _database.Products)
            {
                if (product.CategoryId == categoryId)
                {
                    products.Add(product);
                }
            }

            return products;
        }

        //Tìm kiếm product theo price
        public List<Product> FindProductByPrice(int price)
        {
            List<Product> products = new List<Product>();
            foreach (Product product in _database.Products)
            {
                if (product.Price == price)
                {
                    products.Add(product);
                }
            }

            return products;
        }

        //Sắp xép product theo price
        public List<Product> SortByPrice()
        {
            int length = _database.Products.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (_database.Products[j].Price > _database.Products[j + 1].Price)
                    {
                        var temp = _database.Products[j];
                        _database.Products[j] = _database.Products[j + 1];
                        _database.Products[j + 1] = temp;
                    }
                }
            }
            List<Product> products = _database.Products.ToList();
            return products;
        }

        //Sắp xếp product theo độ dài của tên
        public List<Product> SortByName()
        {
            int length = _database.Products.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length - i - 1; j++)
                {
                    if (_database.Products[j].Name.Length > _database.Products[j + 1].Name.Length)
                    {
                        var temp = _database.Products[j];
                        _database.Products[j] = _database.Products[j + 1];
                        _database.Products[j + 1] = temp;
                    }
                }
            }
            List<Product> products = _database.Products.ToList();
            return products;
        }

        //Sắp xếp product theo tên của category (alphabet)
        public List<Product> SortByCategoryName()
        {
            int length = _database.Products.Length;
            for (int i = 1; i < length; i++)
            {
                var current = _database.Products[i];
                for (int j = i - 1; j >= 0;)
                {
                    if (string.Compare(GetCategoryById(current.CategoryId)?.Name, GetCategoryById(_database.Products[j].CategoryId)?.Name) < 0)
                    {
                        _database.Products[j + 1] = _database.Products[j];
                        j--;
                        _database.Products[j + 1] = current;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            List<Product> products = _database.Products.ToList();
            return products;
        }

        //Map product với category tương ứng
        public List<Product> MapProductByCategory()
        {
            foreach (Product product in _database.Products)
            {
                Category? category = GetCategoryById(product.CategoryId);
                product.Category = category;
            }
            List<Product> products = _database.Products.ToList();
            return products;
        }

        //Lấy ra category theo Id
        private Category? GetCategoryById(int id)
        {
            foreach (Category category in _database.Categories)
            {
                if (category.Id == id)
                {
                    return category;
                }
            }
            return null;
        }

        //Product giá rẻ nhất
        public Product? MinByPrice()
        {
            int length = _database.Products.Length;
            if (length == 0)
            {
                return null;
            }
            Product minPriceProduct = _database.Products[0];
            foreach (Product product in _database.Products)
            {
                if (minPriceProduct.Price > product.Price)
                {
                    minPriceProduct = product;
                }
            }

            return minPriceProduct;
        }


        //Product giá cao nhất
        public Product? MaxByPrice()
        {
            int length = _database.Products.Length;
            if (length == 0)
            {
                return null;
            }
            Product maxPriceProduct = _database.Products[0];
            foreach (Product product in _database.Products)
            {
                if (maxPriceProduct.Price < product.Price)
                {
                    maxPriceProduct = product;
                }
            }

            return maxPriceProduct;
        }
    }
}
