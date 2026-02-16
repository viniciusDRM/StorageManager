using Microsoft.EntityFrameworkCore;
using StorageAPI.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StorageAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Decimal Price { get; set; }
        public int Quantity { get; set; }
        public Categories Category { get; set; } = 0;

    }
}
