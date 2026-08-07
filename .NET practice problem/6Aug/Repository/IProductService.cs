using _6Aug.Models;

namespace _6Aug.Repository
{
    //define all CRUD(create,read,update,delete) method for performing on Product entity
    public interface IProductService
    {
        List<Product> GetProducts(); //fetch all product fron product table

        Product? GetProductById(int id); //fetch product detail from product table based on PId

        void AddProduct(Product product); //add new product record in product table

        void UpdateProduct(Product product); //modify product details from product table based on PId

        void DeleteProduct(int id); //remove product record from product table based on PId
    }
}
