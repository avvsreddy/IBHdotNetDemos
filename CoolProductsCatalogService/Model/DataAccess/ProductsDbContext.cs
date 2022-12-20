using Microsoft.EntityFrameworkCore;

namespace CoolProductsCatalogService.Model.DataAccess
{
    public class ProductsDbContext : DbContext
    {
        // db
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }

        // tables
    }
}
