using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qstn3
{
    internal class InventoryManagementSystem
    {
        public Dictionary<int, Dictionary<string, object>> products = new Dictionary<int, Dictionary<string, object>>();
        public void AddProduct(int productId, string name, decimal price, int stock)
        {
            var productDetails = new Dictionary<string, object>();
            productDetails["Name"] = name;
            productDetails["Price"] = price;
            productDetails["Stock"] = stock;
            products[productId] = productDetails;
        }

        public void UpdateStock(int productId, int newStock)
        {
            if (products.ContainsKey(productId))
            {
                products[productId]["Stock"] = newStock;
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        public void GetProductDetails(int productId)
        {
            if (products.ContainsKey(productId))
            {
                var product = products[productId];
                Console.WriteLine($"Product ID: {productId}");
                Console.WriteLine($"Name: {product["Name"]}");
                Console.WriteLine($"Price: {product["Price"]}");
                Console.WriteLine($"Stock: {product["Stock"]}");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        public void GetLowStockProducts(int threshold)
        {
            Console.WriteLine("Low Stock Products:");
            foreach (var product in products)
            {
                if ((int)product.Value["Stock"] < threshold)
                {
                    Console.WriteLine($"Product ID: {product.Key}");
                }
            }
        }
    }
}
