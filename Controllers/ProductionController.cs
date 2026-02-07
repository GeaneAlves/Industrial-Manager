using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IndustrialManager.Data;
using IndustrialManager.Models;

namespace IndustrialManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductionController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductionController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("suggestions")]
        public async Task<IActionResult> GetProductionSuggestions()
        {
            var material = await _context.RawMaterials.FirstOrDefaultAsync();
            var products = await _context.Products.ToListAsync();

            if (material == null || !products.Any()) return Ok(new List<object>());

            var suggestions = products.Select(p => new {
                ProductName = p.Name,
        // Faz o cálculo automático: estoque total dividido por 2 unidades por produto
                MaxQuantity = (int)(material.StockQuantity / 2), 
            UnitPrice = p.Price
        }).OrderByDescending(s => s.UnitPrice); // Atende o requisito de prioridade por valor

        return Ok(suggestions);
}
    }
}