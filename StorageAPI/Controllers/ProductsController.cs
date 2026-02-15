using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StorageAPI.Data;
using StorageAPI.Models;
using StorageAPI.Services;
namespace StorageAPI.Controllers
{



    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly ProductsDbContext _context;

        private readonly ProductsServices _services;

        [HttpPost]
        [Route("Product/Create")]
        public IActionResult Product(Product prod)
        {

            try
            {
                _services.RegisterProduct(prod);

                return Created();
            }
            catch
            {
                return BadRequest();
            }
            

            
        }



        public ProductsController(ProductsDbContext context, ProductsServices service)
        {
            _context = context;
            _services = service;

        }
    }
}
