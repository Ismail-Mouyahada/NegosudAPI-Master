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
using NegoSudAPI.Services.InventaireService;

namespace NegoSudAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class InventairesController : ControllerBase
    {
        private readonly IInventaireService _inventaireService;

        public InventairesController(IInventaireService inventaireService)
        {
            _inventaireService = inventaireService;
        }

        // GET: api/Inventaires
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Inventaire>>> RecupererToutInventaires()
        {

            return await _inventaireService.RecupererToutInventaires();
        }

        // GET: api/Inventaires/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Inventaire>> RecupererInventaire(int id)
        {

            var inventaire = await _inventaireService.RecupererInventaire(id);

            if (inventaire is null)
            {
                return NotFound("Inventaire introuvable !");
            }

            return Ok(inventaire);
        }

        // PUT: api/Inventaires/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> ModifierInventaire(int id, Inventaire inventaire )
        {

             var result = await _inventaireService.ModifierInventaire(id, inventaire);
            if (result is null)
                return NotFound("Inventaire introuvable");
            return Ok(result);
 

        }

        // POST: api/Inventaires
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Inventaire>> AjouterInventaire(Inventaire inventaire)
        {
            var result = await _inventaireService.AjouterInventaire(inventaire);
            if (result is null)
                return NotFound("Inventaire introuvable");
            return Ok(result);
        }

        // DELETE: api/Inventaires/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> SupprimerInventaire(int id)
        {
           var result = await _inventaireService.SupprimerInventaire(id);
            if (result is null)
                return NotFound("Inventaire introuvable");
            return Ok(result);
        }


    }
}
