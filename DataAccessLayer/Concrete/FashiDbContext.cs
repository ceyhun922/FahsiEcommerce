using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class FashiDbContext : DbContext
    {
        public FashiDbContext(DbContextOptions<FashiDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Size>? Sizes { get; set; }
        public DbSet<Color>? Colors { get; set; }

    }
}