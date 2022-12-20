using CoolProductsCatalogService.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoolProductsCatalogService.Model.DataAccess
{
    public class ProductsDbContext : DbContext
    {
        // db
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=CoolProductsDBIBH5;Integrated Security=True");
        }

        // tables
        public DbSet<Product> Products { get; set; }
    }
}
