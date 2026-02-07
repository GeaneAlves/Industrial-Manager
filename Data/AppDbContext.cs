using Microsoft.EntityFrameworkCore;
using IndustrialManager.Models;

namespace IndustrialManager.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<RawMaterial> RawMaterials { get; set; }
        public DbSet<ProductMaterial> ProductMaterials { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductMaterial>()
                .HasKey(pm => new { pm.ProductId, pm.RawMaterialId });

            base.OnModelCreating(modelBuilder);
        }
    }
}