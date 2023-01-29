using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NegoSudAPI.Data;
using NegoSudAPI.Models;
using Microsoft.AspNetCore.Authorization;

namespace NegoSudAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MagasinsController : ControllerBase
    {
        private readonly NegosudDbContext _context;

        public MagasinsController(NegosudDbContext context)
        {
            _context = context;
        }

        // GET: api/Magasins
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Magasin>>> Getmagasins()
        {
          if (_context.magasins == null)
          {
              return NotFound();
          }
            return await _context.magasins.ToListAsync();
        }

        // GET: api/Magasins/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Magasin>> GetMagasin(int id)
        {
          if (_context.magasins == null)
          {
              return NotFound();
          }
            var magasin = await _context.magasins.FindAsync(id);

            if (magasin == null)
            {
                return NotFound();
            }

            return magasin;
        }

        // PUT: api/Magasins/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMagasin(int id, Magasin magasin)
        {
            if (id != magasin.Id)
            {
                return BadRequest();
            }

            _context.Entry(magasin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MagasinExists(id))
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

        // POST: api/Magasins
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Magasin>> PostMagasin(Magasin magasin)
        {
          if (_context.magasins == null)
          {
              return Problem("Entity set 'NegosudDbContext.magasins'  is null.");
          }
            _context.magasins.Add(magasin);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMagasin", new { id = magasin.Id }, magasin);
        }

        // DELETE: api/Magasins/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMagasin(int id)
        {
            if (_context.magasins == null)
            {
                return NotFound();
            }
            var magasin = await _context.magasins.FindAsync(id);
            if (magasin == null)
            {
                return NotFound();
            }

            _context.magasins.Remove(magasin);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MagasinExists(int id)
        {
            return (_context.magasins?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
