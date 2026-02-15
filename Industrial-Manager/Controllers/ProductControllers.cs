using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IndustrialManager.Data;
using IndustrialManager.Models;

namespace IndustrialManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ProductsController(AppDbContext context) { _context = context; }

        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return Ok(product);
        }

        // RF003 - Associar matéria-prima ao produto
        [HttpPost("add-material")]
        public async Task<IActionResult> AddMaterialToProduct(ProductMaterial association)
        {
            _context.ProductMaterials.Add(association);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}