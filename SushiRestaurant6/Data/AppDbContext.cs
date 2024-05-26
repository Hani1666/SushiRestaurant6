using Microsoft.EntityFrameworkCore;
using SushiRestaurant6.Model;

namespace SushiRestaurant6.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Category { get; set; }
    }
}