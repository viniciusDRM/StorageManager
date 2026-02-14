
using Microsoft.EntityFrameworkCore;

using StorageAPI.Models;


namespace StorageAPI.Data
{
    public class ProductsDbContext :DbContext
    {
       

      

        DbSet<Product> products { get; set; }

       public ProductsDbContext (DbContextOptions<ProductsDbContext> options)
        : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        
    }
}
