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
    public class ElemCommandesController : ControllerBase
    {
        private readonly NegosudDbContext _context;

        public ElemCommandesController(NegosudDbContext context)
        {
            _context = context;
        }

        // GET: api/ElemCommandes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ElemCommande>>> GetelemCommandes()
        {
          if (_context.elemCommandes == null)
          {
              return NotFound();
          }
            return await _context.elemCommandes.ToListAsync();
        }

        // GET: api/ElemCommandes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ElemCommande>> GetElemCommande(int id)
        {
          if (_context.elemCommandes == null)
          {
              return NotFound();
          }
            var elemCommande = await _context.elemCommandes.FindAsync(id);

            if (elemCommande == null)
            {
                return NotFound();
            }

            return elemCommande;
        }

        // PUT: api/ElemCommandes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutElemCommande(int id, ElemCommande elemCommande)
        {
            if (id != elemCommande.Id)
            {
                return BadRequest();
            }

            _context.Entry(elemCommande).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ElemCommandeExists(id))
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

        // POST: api/ElemCommandes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ElemCommande>> PostElemCommande(ElemCommande elemCommande)
        {
          if (_context.elemCommandes == null)
          {
              return Problem("Entity set 'NegosudDbContext.elemCommandes'  is null.");
          }
            _context.elemCommandes.Add(elemCommande);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetElemCommande", new { id = elemCommande.Id }, elemCommande);
        }

        // DELETE: api/ElemCommandes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteElemCommande(int id)
        {
            if (_context.elemCommandes == null)
            {
                return NotFound();
            }
            var elemCommande = await _context.elemCommandes.FindAsync(id);
            if (elemCommande == null)
            {
                return NotFound();
            }

            _context.elemCommandes.Remove(elemCommande);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ElemCommandeExists(int id)
        {
            return (_context.elemCommandes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
