using Microsoft.EntityFrameworkCore;
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

            ProductsDbContext db = new ProductsDbContext();
            // store customer and supp details
            //var c = new Customer { Name = "customer 1", Discount = 100, Email = "customer1@abc.com", Location = "cust Location", Mobile = "34234234", CustomerType = "gold" };
            //var s = new Supplier { Name = "supplier 1", Email = "supplier1@xyz.com", GST = "supplergst", Rating = 8, Location = "suploca", Mobile = "34234234" };
            //db.People.Add(c);
            //db.People.Add(s);
            //db.SaveChanges();

            // get all customers
            //var custs = db.Customers.ToList();
            var supp = db.People.OfType<Supplier>().ToList();

        }

        private static void EgarLoading()
        {
            ProductsDbContext db = new ProductsDbContext();

            // display product name and catagory name
            var result = from p in db.Products//.Include("Catagory")
                             //select new { PName = p.Name, CName = p.Catagory.Name };
                         select p;

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name}\t{item.Catagory.Name}");
            }
        }

        private static void Add3()
        {
            ProductsDbContext db = new ProductsDbContext();
            // add new product with existing catagory(mobiles)

            // get the existing catagory
            var existingCatagory = db.Catagories.Find(1);
            var newProduct = new Product
            {
                Name = "Galaxy S22 Pro",
                Brand = "Samsung",
                Price = 90000,
                Catagory = existingCatagory
            };
            db.Products.Add(newProduct);
            db.SaveChanges();
        }

        private static void Add2()
        {
            ProductsDbContext db = new ProductsDbContext();
            // add new product with new catagory
            Catagory c = new Catagory { Name = "Mobiles" };
            Product p = new Product
            {
                Name = "IPhone 14 Max",
                Price = 150000,
                Brand = "Apple",
                Catagory = c
            };
            db.Products.Add(p);
            //db.Catagories.Add(c);

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
                                select p).ExecuteDelete();  //.FirstOrDefault();
            //db.Products.Remove(productToDel);
            //db.SaveChanges();
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