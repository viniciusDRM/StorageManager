using StorageAPI.Data;
using StorageAPI.Models;

namespace StorageAPI.Services
{
    public class ProductsServices
    {

        private readonly ProductsDbContext _context;


        public ProductsServices(ProductsDbContext context)
        {
            _context = context;
        }
        public void  RegisterProduct(Product prod)
        {
             _context.Add(prod);

             _context.SaveChanges();

        }
    }
}
