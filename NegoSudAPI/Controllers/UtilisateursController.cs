using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NegoSudAPI.Auth;
using NegoSudAPI.Data;
using NegoSudAPI.Models;

namespace NegoSudAPI.Controllers
{
    // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateursController : ControllerBase
    {
        private readonly NegosudDbContext _context;

        public UtilisateursController(NegosudDbContext context)
        {
            _context = context;
        }

        // GET: api/Utilisateurs
        [EnableCors]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Utilisateur>>> Getutilisateurs()
        {
            if (_context.utilisateurs == null)
            {
                return NotFound("Désolé, aucun Enregistrement n'a été trouvé.");
            }
            return await _context.utilisateurs.ToListAsync();
        }

        // GET: api/Utilisateurs/5

        [HttpGet("{id}")]
        public async Task<ActionResult<Utilisateur>> GetUtilisateur(int id)
        {
            if (_context.utilisateurs == null)
            {
                return NotFound("Désolé, aucun Enregistrement n'a été trouvé.");
            }
            var utilisateur = await _context.utilisateurs.FindAsync(id);

            if (utilisateur == null)
            {
                return NotFound("Désolé, aucun Enregistrement n'a été trouvé.");
            }

            return utilisateur;
        }

        // PUT: api/Utilisateurs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUtilisateur(int id, Utilisateur utilisateur)
        {
            if (id != utilisateur.Id)
            {
                return BadRequest("Il semblerait qu'il y a une erreur dans la requête, veuillez réessayer !");
            } else if (utilisateur.MotDePasse == null)
           
            _context.Entry(utilisateur).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UtilisateurExists(id))
                {
                    return NotFound("Désolé, aucun Enregistrement n'a été trouvé.");
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Utilisateurs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [AllowAnonymous]
        [EnableCors]
        [HttpPost]
        public async Task<ActionResult<Utilisateur>> PostUtilisateur(Utilisateur utilisateur)
        {
            // Gestion des exceptions
            if (_context.utilisateurs == null)
            {
                return Problem("Desolé, l'Entité 'NegosudDbContext.utilisateurs'  est vide(nullException).");
            } else if (utilisateur.Id < 0){
                return Problem("Desolé l'identifiant devrait être supérieur a 0");
            }

            // Récuperations des données
            utilisateur.MotDePasse = new PasswordHash().HashedPass(utilisateur.MotDePasse);
            _context.utilisateurs.Add(utilisateur);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetUtilisateur", new { id = utilisateur.Id }, utilisateur);
        }



        // DELETE: api/Utilisateurs/5

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUtilisateur(int id)
        {
            if (_context.utilisateurs == null)
            {
                return NotFound();
            }
            var utilisateur = await _context.utilisateurs.FindAsync(id);
            if (utilisateur == null)
            {
                return NotFound();
            }

            _context.utilisateurs.Remove(utilisateur);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UtilisateurExists(int id)
        {
            return (_context.utilisateurs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
