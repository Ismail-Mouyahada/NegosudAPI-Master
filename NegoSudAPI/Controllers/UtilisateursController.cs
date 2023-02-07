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
using NegoSudAPI.Services.UtilisateurService;

namespace NegoSudAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateursController : ControllerBase
    {
        private readonly IUtilisateurService _utilisateurService;

        public UtilisateursController(IUtilisateurService utilisateurService)
        {
            _utilisateurService = utilisateurService;
        }

        // GET: api/Utilisateurs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Utilisateur>>> RecupererToutUtilisateurs()
        {

            return await _utilisateurService.RecupererToutUtilisateurs();
        }

        // GET: api/Utilisateurs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Utilisateur>> RecupererUtilisateur(int id)
        {

            var utilisateur = await _utilisateurService.RecupererUtilisateur(id);

            if (utilisateur is null)
            {
                return NotFound("Utilisateur introuvable !");
            }

            return Ok(utilisateur);
        }

        // PUT: api/Utilisateurs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}"), Authorize]
        public async Task<IActionResult> ModifierUtilisateur(int id, Utilisateur utilisateur)
        {

            var result = await _utilisateurService.ModifierUtilisateur(id, utilisateur);
            if (result is null)
                return NotFound("Utilisateur introuvable");
            return Ok(result);


        }

        // POST: api/Utilisateurs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Utilisateur>> AjouterUtilisateur(Utilisateur utilisateur)
        {
            var result = await _utilisateurService.AjouterUtilisateur(utilisateur);
            if (result is null)
                return NotFound("Utilisateur introuvable");
            return Ok(result);
        }

        // DELETE: api/Utilisateurs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> SupprimerUtilisateur(int id)
        {
            var result = await _utilisateurService.SupprimerUtilisateur(id);
            if (result is null)
                return NotFound("Utilisateur introuvable");
            return Ok(result);
        }


    }
}
