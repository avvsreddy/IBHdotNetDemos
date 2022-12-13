using Microsoft.EntityFrameworkCore;
using ProductsManagementApp.Entities;

namespace ProductsManagementApp.DataAccess
{
    public class ProductsDbContext : DbContext
    {

        // map with database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies()
                .UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=ProductsDbIBH55;Integrated Security=True;MultipleActiveResultSets=True");
            optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API
            //modelBuilder.Entity<Book>().ToTable("tbl_books");
            //modelBuilder.Entity<Customer>().UseTpcMappingStrategy();
            //modelBuilder.Entity<Supplier>().UseTpcMappingStrategy();
            modelBuilder.Entity<Person>().UseTpcMappingStrategy();

        }

        // map with tables

        public DbSet<Product> Products { get; set; }
        //public DbSet<Book> Books { get; set; }
        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Person> People { get; set; }
    }
}
