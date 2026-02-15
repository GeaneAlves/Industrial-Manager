using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IndustrialManager.Data;
using IndustrialManager.Models;

namespace IndustrialManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RawMaterialsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RawMaterialsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/RawMaterials (Listar todos)
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RawMaterial>>> GetRawMaterials()
        {
            return await _context.RawMaterials.ToListAsync();
        }

        // POST: api/RawMaterials (Cadastrar novo)
        [HttpPost]
        public async Task<ActionResult<RawMaterial>> PostRawMaterial(RawMaterial rawMaterial)
        {
            _context.RawMaterials.Add(rawMaterial);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetRawMaterials), new { id = rawMaterial.Id }, rawMaterial);
        }
    }
}