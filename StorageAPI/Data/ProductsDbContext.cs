
using Microsoft.EntityFrameworkCore;

using StorageAPI.Models;


namespace StorageAPI.Data
{
    public class ProductsDbContext :DbContext
    {

        DbSet<Product> products { get; set; }

        public ProductsDbContext()
        {

        }

       public ProductsDbContext (DbContextOptions<ProductsDbContext> options)
        : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().HasKey(a => a.Id);
            modelBuilder.Entity<Product>().Property(a => a.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Product>().Property(a => a.Preco).HasColumnType("decimal(18,4");

            

            base.OnModelCreating(modelBuilder);
        }
    }
}
