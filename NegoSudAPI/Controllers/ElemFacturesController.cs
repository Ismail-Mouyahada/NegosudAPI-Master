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
    public class ElemFacturesController : ControllerBase
    {
        private readonly NegosudDbContext _context;

        public ElemFacturesController(NegosudDbContext context)
        {
            _context = context;
        }

        // GET: api/ElemFactures
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ElemFacture>>> GetelemFactures()
        {
          if (_context.elemFactures == null)
          {
              return NotFound();
          }
            return await _context.elemFactures.ToListAsync();
        }

        // GET: api/ElemFactures/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ElemFacture>> GetElemFacture(int id)
        {
          if (_context.elemFactures == null)
          {
              return NotFound();
          }
            var elemFacture = await _context.elemFactures.FindAsync(id);

            if (elemFacture == null)
            {
                return NotFound();
            }

            return elemFacture;
        }

        // PUT: api/ElemFactures/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutElemFacture(int id, ElemFacture elemFacture)
        {
            if (id != elemFacture.Id)
            {
                return BadRequest();
            }

            _context.Entry(elemFacture).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ElemFactureExists(id))
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

        // POST: api/ElemFactures
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ElemFacture>> PostElemFacture(ElemFacture elemFacture)
        {
          if (_context.elemFactures == null)
          {
              return Problem("Entity set 'NegosudDbContext.elemFactures'  is null.");
          }
            _context.elemFactures.Add(elemFacture);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetElemFacture", new { id = elemFacture.Id }, elemFacture);
        }

        // DELETE: api/ElemFactures/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteElemFacture(int id)
        {
            if (_context.elemFactures == null)
            {
                return NotFound();
            }
            var elemFacture = await _context.elemFactures.FindAsync(id);
            if (elemFacture == null)
            {
                return NotFound();
            }

            _context.elemFactures.Remove(elemFacture);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ElemFactureExists(int id)
        {
            return (_context.elemFactures?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
