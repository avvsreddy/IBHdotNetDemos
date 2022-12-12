using Microsoft.EntityFrameworkCore;
using ProductsManagementApp.Entities;

namespace ProductsManagementApp.DataAccess
{
    public class ProductsDbContext : DbContext
    {

        // map with database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=ProductsDbIBH5;Integrated Security=True");
            //optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
        }

        // map with tables

        public DbSet<Product> Products { get; set; }

    }
}
