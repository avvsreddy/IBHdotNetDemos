using ProductsManagementApp.Entities;

namespace ProductsManagementApp.DataAccess
{
    public interface IProdutsRepository
    {
        void Save(Product productToSave);
        void Update(Product productToUpate);

        Product GetProduct(int id);

        List<Product> GetProducts();

    }
}
