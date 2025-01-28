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

        /// <summary>
        /// Get all the products
        /// </summary> 
        /// <response code="201">An array with the products</response> 
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _context.Products.ToListAsync();
            return Ok(products);
        }

        /// <summary>
        /// Update a product
        /// </summary>
        /// <param name="id"></param>
        /// <param name="product"></param>
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, Product product)
        {
            if (id != product.id) return BadRequest();

            product.updated_at = DateTime.Now;
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        /// <summary>
        /// Update a list of given products
        /// </summary> 
        /// <param name="products"></param>
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

        /// <summary>
        /// Delete a product
        /// </summary>
        /// <param name="id"></param> 
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null) return NotFound();

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}