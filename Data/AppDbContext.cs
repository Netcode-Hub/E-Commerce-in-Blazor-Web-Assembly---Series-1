using Microsoft.EntityFrameworkCore;
using ORMExplained.Shared.Models;
namespace ORMExplained.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
