using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generic.Data;
using Generic.Entities;

namespace Generic.Repositories
{
    internal class ProductRepository
    {
        public GenericResponse<List<Product>> GetAllProducts()
        {
            var products = DataStore.Products;
            return new GenericResponse<List<Product>>
            {
                Success = true,
                Data = products,
            };
        }

        public GenericResponse<Product> GetProductById(int id)
        {
            var product = DataStore.Products.FirstOrDefault(x => x.Id == id);
            if (product == null)
            {
                return new GenericResponse<Product>
                {
                    Success = false,
                    Message = "Product not found",
                };
            }

            return new GenericResponse<Product>
            {
                Success = true,
                Data = product,
            };
        }
    }
}
