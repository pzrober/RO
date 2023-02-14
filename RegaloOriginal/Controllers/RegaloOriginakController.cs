using ComuniDev.WebEFCore.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace RegaloOriginal.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class RegaloOriginalController : ControllerBase
    {
        private readonly RegaloOriginalDbContext _context;

        public RegaloOriginalController(RegaloOriginalDbContext context)
        {
            _context = context;
        }

        // GET: api/RegaloOriginal
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemVenta>>> GetItemVenta()
        {
            if (_context.ItemVenta == null)
            {
                return NotFound();
            }
            return await _context.ItemVenta.ToListAsync();
        }

        // GET: api/RegaloOriginal/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemVenta>> GetItemVenta(int id)
        {
            if (_context.ItemVenta == null)
            {
                return NotFound();
            }
            var tv = await _context.ItemVenta.FindAsync(id);

            if (tv == null)
            {
                return NotFound();
            }

            return tv;
        }

        // PUT: api/RegaloOriginal/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemVenta(int id, ItemVenta iv)
        {
            if (id != iv.Id)
            {
                return BadRequest();
            }

            _context.Entry(iv).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                    throw;
            }

            return NoContent();
        }

        // POST: api/RegaloOriginal
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ItemVenta>> PostItemVenta(ItemVenta iv)
        {
            if (_context.ItemVenta == null)
            {
                return Problem("Entity set 'RegaloOriginalDbContext.ItemVenta'  is null.");
            }
            _context.ItemVenta.Add(iv);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItemVenta", new { id = iv.Id }, iv);
        }

        // DELETE: api/RegaloOriginal/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItemVenta(int id)
        {
            if (_context.ItemVenta == null)
            {
                return NotFound();
            }
            var iv = await _context.ItemVenta.FindAsync(id);
            if (iv == null)
            {
                return NotFound();
            }

            _context.ItemVenta.Remove(iv);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ItemVentaExists(int id)
        {
            return (_context.ItemVenta?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
