using _7Aug.Data;
using _7Aug.Models;
using _7Aug.Repository;

namespace _7Aug.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext context;

        public ProductService(AppDbContext context)
        {
            this.context = context;
        }
        public Product? GetProductById(int id)
        {
            return context.Products.Find(id);
        }

        public List<Product> GetProducts()
        {
            return context.Products.ToList();
        }

        Product IProductService.AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return product;
        }
    }
}
