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
using NegoSudAPI.Services.FactureService;

namespace NegoSudAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class FacturesController : ControllerBase
    {
        private readonly IFactureService _factureService;

        public FacturesController(IFactureService factureService)
        {
            _factureService = factureService;
        }

        // GET: api/Factures
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Facture>>> RecupererToutFactures()
        {

            return await _factureService.RecupererToutFactures();
        }

        // GET: api/Factures/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Facture>> RecupererFacture(int id)
        {

            var facture = await _factureService.RecupererFacture(id);

            if (facture is null)
            {
                return NotFound("Facture introuvable !");
            }

            return Ok(facture);
        }

        // PUT: api/Factures/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> ModifierFacture(int id, Facture facture )
        {

             var result = await _factureService.ModifierFacture(id, facture);
            if (result is null)
                return NotFound("Facture introuvable");
            return Ok(result);
 

        }

        // POST: api/Factures
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Facture>> AjouterFacture(Facture facture)
        {
            var result = await _factureService.AjouterFacture(facture);
            if (result is null)
                return NotFound("Facture introuvable");
            return Ok(result);
        }

        // DELETE: api/Factures/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> SupprimerFacture(int id)
        {
           var result = await _factureService.SupprimerFacture(id);
            if (result is null)
                return NotFound("Facture introuvable");
            return Ok(result);
        }


    }
}
