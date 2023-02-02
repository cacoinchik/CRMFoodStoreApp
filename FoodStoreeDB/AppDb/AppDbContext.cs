using System.Data.Entity;

namespace FoodStoreeDB.AppDb
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("FoodStoreDB") { }
        public DbSet<Product> Products { get; set;}
        public DbSet<Category> Categories { get; set;}

    }
}
