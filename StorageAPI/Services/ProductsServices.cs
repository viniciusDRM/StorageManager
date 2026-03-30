using StorageAPI.Data;
using StorageAPI.Models;
using StorageAPI.Exceptions;

namespace StorageAPI.Services
{
    public class ProductsServices
    {

        private readonly ProductsDbContext _context;


        public ProductsServices(ProductsDbContext context)
        {
            _context = context;
        }
        public void  InsertProduct(Product prod)
        {
             _context.products.Add(prod);

            _context.SaveChanges();
        }



        public Product ViewProduct(int Id)
        {
            var prod = _context.products.SingleOrDefault(p => p.Id == Id);

            if(prod != null)
            {
                return prod;
            }

            else
            {
                throw new ProductExeption("Product not found");
            }
        }

        public void RemoveProduct(int Id)
        {
            var prod = _context.products.FirstOrDefault(p => p.Id == Id);

            if(prod!= null)
            {
                _context.products.Remove(prod);
                _context.SaveChanges();
            }
            else
            {
                throw new ProductExeption("Product not found");
            }
        }

        public void EditProduct(int id,string? name,decimal price)
        {
            
            var prod = _context.products.FirstOrDefault(p => p.Id == id);

            if(prod!= null)
            {
                prod.Name = name;
                prod.Price = price;

                _context.SaveChanges();
            }
            else
            {   
                throw new ProductExeption("Product not found");
            }
        }
    }
}
