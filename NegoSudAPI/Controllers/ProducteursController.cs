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
    public class ProducteursController : ControllerBase
    {
        private readonly NegosudDbContext _context;

        public ProducteursController(NegosudDbContext context)
        {
            _context = context;
        }

        // GET: api/Producteurs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producteur>>> Getproducteurs()
        {
          if (_context.producteurs == null)
          {
              return NotFound();
          }
            return await _context.producteurs.ToListAsync();
        }

        // GET: api/Producteurs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Producteur>> GetProducteur(int id)
        {
          if (_context.producteurs == null)
          {
              return NotFound();
          }
            var producteur = await _context.producteurs.FindAsync(id);

            if (producteur == null)
            {
                return NotFound();
            }

            return producteur;
        }

        // PUT: api/Producteurs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProducteur(int id, Producteur producteur)
        {
            if (id != producteur.Id)
            {
                return BadRequest();
            }

            _context.Entry(producteur).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProducteurExists(id))
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

        // POST: api/Producteurs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Producteur>> PostProducteur(Producteur producteur)
        {
          if (_context.producteurs == null)
          {
              return Problem("Entity set 'NegosudDbContext.producteurs'  is null.");
          }
            _context.producteurs.Add(producteur);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProducteur", new { id = producteur.Id }, producteur);
        }

        // DELETE: api/Producteurs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProducteur(int id)
        {
            if (_context.producteurs == null)
            {
                return NotFound();
            }
            var producteur = await _context.producteurs.FindAsync(id);
            if (producteur == null)
            {
                return NotFound();
            }

            _context.producteurs.Remove(producteur);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProducteurExists(int id)
        {
            return (_context.producteurs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
