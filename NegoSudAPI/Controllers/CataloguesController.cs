using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NegoSudAPI.Data;
using NegoSudAPI.Models;

namespace NegoSudAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CataloguesController : ControllerBase
    {
        private readonly NegosudDbContext _context;

        public CataloguesController(NegosudDbContext context)
        {
            _context = context;
        }

        // GET: api/Catalogues
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Catalogue>>> Getcatalogues()
        {
          if (_context.catalogues == null)
          {
              return NotFound();
          }
            return await _context.catalogues.ToListAsync();
        }

        // GET: api/Catalogues/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Catalogue>> GetCatalogue(int id)
        {
          if (_context.catalogues == null)
          {
              return NotFound();
          }
            var catalogue = await _context.catalogues.FindAsync(id);

            if (catalogue == null)
            {
                return NotFound();
            }

            return catalogue;
        }

        // PUT: api/Catalogues/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCatalogue(int id, Catalogue catalogue)
        {
            if (id != catalogue.Id)
            {
                return BadRequest();
            }

            _context.Entry(catalogue).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CatalogueExists(id))
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

        // POST: api/Catalogues
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Catalogue>> PostCatalogue(Catalogue catalogue)
        {
          if (_context.catalogues == null)
          {
              return Problem("Entity set 'NegosudDbContext.catalogues'  is null.");
          }
            _context.catalogues.Add(catalogue);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCatalogue", new { id = catalogue.Id }, catalogue);
        }

        // DELETE: api/Catalogues/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCatalogue(int id)
        {
            if (_context.catalogues == null)
            {
                return NotFound();
            }
            var catalogue = await _context.catalogues.FindAsync(id);
            if (catalogue == null)
            {
                return NotFound();
            }

            _context.catalogues.Remove(catalogue);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CatalogueExists(int id)
        {
            return (_context.catalogues?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
