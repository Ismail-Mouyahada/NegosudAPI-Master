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
using NegoSudAPI.Services.CommandeService;

namespace NegoSudAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CommandesController : ControllerBase
    {
        private readonly ICommandeService _commandeService;

        public CommandesController(ICommandeService commandeService)
        {
            _commandeService = commandeService;
        }

        // GET: api/Commandes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Commande>>> RecupererToutCommandes()
        {

            return await _commandeService.RecupererToutCommandes();
        }

        // GET: api/Commandes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Commande>> RecupererCommande(int id)
        {

            var commande = await _commandeService.RecupererCommande(id);

            if (commande is null)
            {
                return NotFound("Commande introuvable !");
            }

            return Ok(commande);
        }

        // PUT: api/Commandes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> ModifierCommande(int id, Commande commande )
        {

             var result = await _commandeService.ModifierCommande(id, commande);
            if (result is null)
                return NotFound("Commande introuvable");
            return Ok(result);
 

        }

        // POST: api/Commandes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Commande>> AjouterCommande(Commande commande)
        {
            var result = await _commandeService.AjouterCommande(commande);
            if (result is null)
                return NotFound("Commande introuvable");
            return Ok(result);
        }

        // DELETE: api/Commandes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> SupprimerCommande(int id)
        {
           var result = await _commandeService.SupprimerCommande(id);
            if (result is null)
                return NotFound("Commande introuvable");
            return Ok(result);
        }


    }
}
