using ProductsManagementApp.DataAccess;
using ProductsManagementApp.Entities;

namespace ProductsManagementApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Manage Products
            // Data Access Technology: EF
            // Approach : Code First
            // Create Entity Classes
            // Map Class with Table

            //ProductsDbContext db = new ProductsDbContext();
            ProductsRepository repo = new ProductsRepository();
            repo.
            Product p2 = new Product { Name = "Galaxy S22 Max", Price = 89000, Brand = "Samsung" };
            db.Products.Add(p2);
            db.SaveChanges();
        }

        private static void Update()
        {
            // update the product
            ProductsDbContext db = new ProductsDbContext();
            var productToUpdate = db.Products.Find(1);
            productToUpdate.Price = 80000;
            db.SaveChanges();
        }

        private static void delete()
        {
            // Delete pid 4
            ProductsDbContext db = new ProductsDbContext();
            var productToDel = (from p in db.Products
                                where p.ProductID == 4
                                select p).FirstOrDefault();
            db.Products.Remove(productToDel);
            db.SaveChanges();
        }

        private static void Total()
        {
            // find the total value of all products
            ProductsDbContext db = new ProductsDbContext();
            double total = (from p in db.Products
                            select p.Price).Sum();

            Console.WriteLine(total);
        }

        private static void Frist()
        {
            // get first product

            ProductsDbContext db = new ProductsDbContext();
            var firstProduct = (from p in db.Products
                                select p).First();
            Console.WriteLine(firstProduct.Name);
        }

        private static void All()
        {
            // GEt all products
            ProductsDbContext db = new ProductsDbContext();
            // LINQ to Entities

            var allProducts = from p in db.Products
                              select p;

            foreach (var item in allProducts)
            {
                Console.WriteLine($"{item.Name}\t{item.Price}");
            }
        }

        private static void Add()
        {
            // add new product

            Product p1 = new Product();
            p1.Name = "IPhone XI";
            p1.Price = 85000;

            Product p2 = new Product { Name = "Galaxy S22", Price = 89000 };
            Product p3 = new Product { Name = "Dell XPS 13", Price = 75000 };

            ProductsDbContext db = new ProductsDbContext();
            db.Products.Add(p1);
            db.Products.Add(p2);
            db.Products.Add(p3);

            db.SaveChanges();
            Console.WriteLine("Saved...");
        }
    }
}