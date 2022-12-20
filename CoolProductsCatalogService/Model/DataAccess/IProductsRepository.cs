using CoolProductsCatalogService.Model.Entities;

namespace CoolProductsCatalogService.Model.DataAccess
{
    public interface IProductsRepository
    {
        // get
        List<Product> GetProducts();
        Product GetProductById(int id);
        Product GetProductByName(string name);
        List<Product> GetProductsByBrand(string brand);
        List<Product> GetProductsByCatagory(string catagory);
        List<Product> GetProductsByPrice(double price);
        List<Product> GetProductsByCountry(string country);

        // create/post
        void AddProduct(Product product);
        //update/put
        void UpdateProduct(Product product);
        // delete
        void DeleteProduct(int productId);





    }
}
