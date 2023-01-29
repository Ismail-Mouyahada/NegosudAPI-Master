using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NegoSudAPI.Data;
using NegoSudAPI.Models;

namespace NegoSudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PayssController : ControllerBase
    {
        private readonly NegosudDbContext _context;

        public PayssController(NegosudDbContext context)
        {
            _context = context;
        }

        // GET: api/Payss
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pays>>> Getpays()
        {
          if (_context.pays == null)
          {
              return NotFound();
          }
            return await _context.pays.ToListAsync();
        }

        // GET: api/Payss/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pays>> GetPays(int id)
        {
          if (_context.pays == null)
          {
              return NotFound();
          }
            var pays = await _context.pays.FindAsync(id);

            if (pays == null)
            {
                return NotFound();
            }

            return pays;
        }

        // PUT: api/Payss/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPays(int id, Pays pays)
        {
            if (id != pays.Id)
            {
                return BadRequest();
            }

            _context.Entry(pays).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaysExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Payss
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pays>> PostPays(Pays pays)
        {
          if (_context.pays == null)
          {
              return Problem("Entity set 'NegosudDbContext.pays'  is null.");
          }
            _context.pays.Add(pays);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPays", new { id = pays.Id }, pays);
        }

        // DELETE: api/Payss/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePays(int id)
        {
            if (_context.pays == null)
            {
                return NotFound();
            }
            var pays = await _context.pays.FindAsync(id);
            if (pays == null)
            {
                return NotFound();
            }

            _context.pays.Remove(pays);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PaysExists(int id)
        {
            return (_context.pays?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
