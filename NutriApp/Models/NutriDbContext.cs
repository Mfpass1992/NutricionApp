using Microsoft.EntityFrameworkCore;

namespace NutriApp.Models
{
    public class NutriDbContext : DbContext
    {
        public NutriDbContext(DbContextOptions<NutriDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Attributes> Attributes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Category>().ToTable("Categories");
            modelBuilder.Entity<SubCategory>().ToTable("SubCategories");
            modelBuilder.Entity<Attributes>().ToTable("Attributes").HasKey(c => new {c.Id});
        }
    }
}
