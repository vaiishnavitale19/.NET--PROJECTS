using _6_Aug.Data;
using _6Aug.Models;
using _6Aug.Repository;

//implement logic for CRUD method of Product entity
//service = business logic
//dbcontext = add, savechanges, find, tolist, update, remove

namespace _6_Aug.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext context;

        public ProductService(AppDbContext context)
        {
            this.context = context;
        }

        public void AddProduct(Product product)
        {
            context.products.Add(product); // implementation of adding new Product
            context.SaveChanges(); // saving new added product in table
        }

        public void DeleteProduct(int id)
        {
            var product = context.products.Find(id);

            if (product != null) // check product available
            {
                context.products.Remove(product); // remove existing product from table
                context.SaveChanges(); // saving change in database
            }
        }

        public Product? GetProductById(int id)
        {
            return context.products.Find(id); // get Product by ID
        }

        public List<Product> GetProducts()
        {
            return context.products.ToList(); // get all Products
        }

        public void UpdateProduct(Product product)
        {
            context.products.Update(product); // update product details
            context.SaveChanges(); // save changes
        }
    }
}