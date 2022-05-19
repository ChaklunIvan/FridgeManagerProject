using InnowiseTask.Server.Data.Models;
using InnowiseTask.Server.Data.Models.Configurations;
using Microsoft.EntityFrameworkCore;

namespace InnowiseTask.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<Fridge> Fridges { get; set; }
        public DbSet<FridgeModel> FridgeModels { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<FridgeProduct> FridgeProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FridgeProduct>().HasKey(sc => new { sc.FridgeId, sc.ProductId });

            modelBuilder.ApplyConfiguration(new FridgeModelConfiguration());
            //modelBuilder.ApplyConfiguration(new FridgeProductConfiguration());
            modelBuilder.ApplyConfiguration(new FridgeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }

    }
}
