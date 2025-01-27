using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using value_analysis_server.Api.Database;
using value_analysis_server.Api.Models;

namespace value_analysis_backend.Api.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private readonly DBContext _context;

        public ProductController(DBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _context.Products.ToListAsync();
            return Ok(products);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, Product product)
        {
            if (id != product.id) return BadRequest();

            product.updated_at = DateTime.Now;
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPatch("batch")]
        public async Task<IActionResult> UpdateBatch(List<Product> products)
        {
            foreach (var product in products)
            {
                product.updated_at = DateTime.Now;
                _context.Entry(product).State = EntityState.Modified;
            }
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}