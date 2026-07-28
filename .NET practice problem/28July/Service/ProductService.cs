using _28July.Models;

namespace _28July.Service
{
    public class ProductService : IProductService
    {
        private static List<Product> products = new List<Product>()
        {
            new Product
            {
                Id = 1,
                Name = "Charger",
                Price = 500,
                Quantity = 10
            },

            new Product
            {
                Id = 2,
                Name = "Laptop",
                Price = 50000,
                Quantity = 100
            },

            new Product
            {
                Id = 3,
                Name = "Phone",
                Price = 78000,
                Quantity = 1000
            },

            new Product
            {
                Id = 4,
                Name = "Pen Drive",
                Price = 800,
                Quantity = 55
            }
        };

        public List<Product> GetAll()
        {
            return products;
        }

        public Product? GetById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public Product AddProduct(Product product)
        {
            products.Add(product);
            return product;
        }

        public Product? UpdateProduct(int id, Product product)
        {
            var existing = products.FirstOrDefault(p => p.Id == id);

            if (existing == null)
                return null;

            existing.Name = product.Name;
            existing.Price = product.Price;
            existing.Quantity = product.Quantity;

            return existing;
        }

        public bool DeleteProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return false;

            products.Remove(product);

            return true;
        }
    }
}