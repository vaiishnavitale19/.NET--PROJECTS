using _7Aug.Models;

namespace _7Aug.Repository


{   //defines what operations are availabe
    public interface IProductService
    {
        List<Product> GetProducts();

        Product? GetProductById(int id);

        Product AddProduct(Product product);




    }
}
