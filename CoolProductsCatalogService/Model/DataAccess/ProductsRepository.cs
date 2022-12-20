using CoolProductsCatalogService.Model.Entities;

namespace CoolProductsCatalogService.Model.DataAccess
{
    public class ProductsRepository : IProductsRepository
    {

        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetProductByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByBrand(string brand)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCatagory(string catagory)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCountry(string country)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByPrice(double price)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
