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

        /// <summary>
        /// Get an Order with an given id
        /// </summary>
        /// <param name="id"></param>
        /// <response code="201">An Order object</response>
        /// <response code="404">404 error if result is null</response>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null) return NotFound();
            return Ok(order);
        }

        /// <summary>
        /// Create a new Order element
        /// </summary>
        /// <body name="order"></body>
        /// <response code="201">The created Order object</response>
        [HttpPost]
        public async Task<IActionResult> Create(Order order)
        {
            order.created_at = DateTime.Now;
            order.updated_at = DateTime.Now;
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = order.id }, order);
        }

        /// <summary>
        /// Get the latest order created
        /// </summary>
        /// <response code="201">An Order object</response>
        /// <response code="404">404 error if result is null</response>
        [HttpGet]
        [HttpGet("latest")]
        public async Task<IActionResult> GetLatest()
        {
            var latestOrder = await _context.Orders
                .OrderByDescending(p => p.id).FirstOrDefaultAsync();

            if (latestOrder == null) return NotFound();
            return Ok(latestOrder);
        }

        /// <summary>
        /// Update an order given a id and an Order object
        /// </summary>
        /// <param name="id"></param>
        /// <param name="product"></param>
        [HttpPatch("{id}")]
        public async Task<IActionResult> Update(Guid id, Product product)
        {
            if (id != product.id) return BadRequest();

            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        /// <summary>
        /// Delete an order given a id
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