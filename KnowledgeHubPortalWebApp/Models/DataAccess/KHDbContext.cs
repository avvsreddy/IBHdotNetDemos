using KnowledgeHubPortalWebApp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace KnowledgeHubPortalWebApp.Models.DataAccess
{
    public class KHDbContext : DbContext
    {
        // db config
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=KHPortalDbIBH5;Integrated Security=True");
        }
        // tables config
        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<Article> Articles { get; set; }
    }
}
