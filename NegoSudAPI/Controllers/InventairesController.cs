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
    public class InventairesController : ControllerBase
    {
        private readonly NegosudDbContext _context;

        public InventairesController(NegosudDbContext context)
        {
            _context = context;
        }

        // GET: api/Inventaires
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Inventaire>>> Getinventaires()
        {
          if (_context.inventaires == null)
          {
              return NotFound();
          }
            return await _context.inventaires.ToListAsync();
        }

        // GET: api/Inventaires/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Inventaire>> GetInventaire(int id)
        {
          if (_context.inventaires == null)
          {
              return NotFound();
          }
            var inventaire = await _context.inventaires.FindAsync(id);

            if (inventaire == null)
            {
                return NotFound();
            }

            return inventaire;
        }

        // PUT: api/Inventaires/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInventaire(int id, Inventaire inventaire)
        {
            if (id != inventaire.Id)
            {
                return BadRequest();
            }

            _context.Entry(inventaire).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InventaireExists(id))
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

        // POST: api/Inventaires
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Inventaire>> PostInventaire(Inventaire inventaire)
        {
          if (_context.inventaires == null)
          {
              return Problem("Entity set 'NegosudDbContext.inventaires'  is null.");
          }
            _context.inventaires.Add(inventaire);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInventaire", new { id = inventaire.Id }, inventaire);
        }

        // DELETE: api/Inventaires/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInventaire(int id)
        {
            if (_context.inventaires == null)
            {
                return NotFound();
            }
            var inventaire = await _context.inventaires.FindAsync(id);
            if (inventaire == null)
            {
                return NotFound();
            }

            _context.inventaires.Remove(inventaire);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InventaireExists(int id)
        {
            return (_context.inventaires?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
