using CoolProductsCatalogService.Model.Entities;

namespace CoolProductsCatalogService.Model.DataAccess
{
    public class ProductsRepository : IProductsRepository
    {
        private ProductsDbContext db = new ProductsDbContext();

        public void AddProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }

        public void DeleteProduct(int productId)
        {
            var productToDel = db.Products.Find(productId);
            db.Products.Remove(productToDel);
            db.SaveChanges();

        }

        public Product GetProductById(int id)
        {
            return db.Products.Find(id);
        }

        public Product GetProductByName(string name)
        {
            return (from p in db.Products
                    where p.Name == name
                    select p).FirstOrDefault();
        }

        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }

        public List<Product> GetProductsByBrand(string brand)
        {
            return (from p in db.Products
                    where p.Brand.Contains(brand)
                    select p).ToList();
        }

        public List<Product> GetProductsByCatagory(string catagory)
        {
            return (from p in db.Products
                    where p.Catagory.Contains(catagory)
                    select p).ToList();
        }

        public List<Product> GetProductsByCountry(string country)
        {
            return (from p in db.Products
                    where p.Country.Contains(country)
                    select p).ToList();
        }

        public List<Product> GetProductsByPrice(double price)
        {
            return (from p in db.Products
                    where p.Price >= price
                    select p).ToList();
        }

        public void UpdateProduct(Product product)
        {
            db.Products.Update(product);
            db.SaveChanges();
        }
    }
}
