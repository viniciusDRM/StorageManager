using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using StorageAPI.Data;
using StorageAPI.Models;
using StorageAPI.Services;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;
namespace StorageAPI.Controllers
{



    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly ProductsDbContext _context;

        private readonly ProductsServices _services;

        
        [HttpPost("Product/{prod}")]
        public IActionResult InsertProduct(Product prod)
        {

            try
            {
                _services.InsertProduct(prod);

                return Created();
            }
            catch
            {
                return BadRequest();
            }           
        }
        

        [HttpDelete("Product/Delete/{Id}")]
        public IActionResult RemoveProduct(int Id)
        {

            try
            {
                _services.RemoveProduct(Id);
                return Ok();

            }catch
            {
                return BadRequest();
            }

        }

        [HttpPut("product/Edit/{Id}")]
        public IActionResult EditProduct(int Id, string name, decimal price)
        {

            //TODO
            return NotFound();
        }

        [HttpGet("product/{id}")]
        public IActionResult ViewProduct(int id)
        {
            var prod = _services.ViewProduct(id);

            if(prod != null)
            {
                return Ok(prod);
            }
            else
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
