using ProductsManagementApp.Entities;

namespace ProductsManagementApp.DataAccess
{
    public class ProductsRepository : IProdutsRepository
    {
        private ProductsDbContext db = new ProductsDbContext();
        public Product GetProduct(int id)
        {
            return db.Products.Find(id);
        }

        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }

        public void Save(Product productToSave)
        {
            db.Products.Add(productToSave);
            db.SaveChanges();
        }

        public void Update(Product productToUpate)
        {
            db.Products.Update(productToUpate);
            db.SaveChanges();
        }
    }
}
