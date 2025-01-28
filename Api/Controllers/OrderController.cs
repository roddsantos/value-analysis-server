using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using value_analysis_server.Api.Database;
using value_analysis_server.Api.Models;

namespace value_analysis_server.Api.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrderController : ControllerBase
    {
        private readonly DBContext _context;

        public OrderController(DBContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null) return NotFound();
            return Ok(order);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Order order)
        {
            order.created_at = DateTime.Now;
            order.updated_at = DateTime.Now;
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = order.id }, order);
        }

        [HttpGet]
        [HttpGet("latest")]
        public async Task<IActionResult> GetLatest()
        {
            var latestOrder = await _context.Orders
                .OrderByDescending(p => p.id).FirstOrDefaultAsync();

            if (latestOrder == null) return NotFound();
            return Ok(latestOrder);
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> Update(Guid id, Product product)
        {
            if (id != product.id) return BadRequest();

            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

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