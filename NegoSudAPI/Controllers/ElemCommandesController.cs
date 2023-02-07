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
using NegoSudAPI.Services.ElemCommandeService;

namespace NegoSudAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ElemCommandesController : ControllerBase
    {
        private readonly IElemCommandeService _elemcommandeService;

        public ElemCommandesController(IElemCommandeService elemcommandeService)
        {
            _elemcommandeService = elemcommandeService;
        }

        // GET: api/ElemCommandes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ElemCommande>>> RecupererToutElemCommandes()
        {

            return await _elemcommandeService.RecupererToutElemCommandes();
        }

        // GET: api/ElemCommandes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ElemCommande>> RecupererElemCommande(int id)
        {

            var elemcommande = await _elemcommandeService.RecupererElemCommande(id);

            if (elemcommande is null)
            {
                return NotFound("ElemCommande introuvable !");
            }

            return Ok(elemcommande);
        }

        // PUT: api/ElemCommandes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> ModifierElemCommande(int id, ElemCommande elemcommande )
        {

             var result = await _elemcommandeService.ModifierElemCommande(id, elemcommande);
            if (result is null)
                return NotFound("ElemCommande introuvable");
            return Ok(result);
 

        }

        // POST: api/ElemCommandes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ElemCommande>> AjouterElemCommande(ElemCommande elemcommande)
        {
            var result = await _elemcommandeService.AjouterElemCommande(elemcommande);
            if (result is null)
                return NotFound("ElemCommande introuvable");
            return Ok(result);
        }

        // DELETE: api/ElemCommandes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> SupprimerElemCommande(int id)
        {
           var result = await _elemcommandeService.SupprimerElemCommande(id);
            if (result is null)
                return NotFound("ElemCommande introuvable");
            return Ok(result);
        }


    }
}
