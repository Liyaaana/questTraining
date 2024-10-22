using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 18. Filter and Sort Products by Price from a list of products, return those with prices greater than $100,
// sorted in ascending order.
namespace Qst18
{
    internal class Program
    {
        public class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }
        }
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product { Name = "Product 1", Price = 50 },
                new Product { Name = "Product 2", Price = 150 },
                new Product { Name = "Product 3", Price = 200 }
            };

            var res = products.Where(p => p.Price > 100).OrderBy(p => p.Price).ToList();
            foreach (var product in res)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
            }
        }
    }
}
