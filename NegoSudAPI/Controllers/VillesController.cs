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
using NegoSudAPI.Services.VilleService;

namespace NegoSudAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class VillesController : ControllerBase
    {
        private readonly IVilleService _villeService;

        public VillesController(IVilleService villeService)
        {
            _villeService = villeService;
        }

        // GET: api/Villes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ville>>> RecupererToutVilles()
        {

            return await _villeService.RecupererToutVilles();
        }

        // GET: api/Villes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ville>> RecupererVille(int id)
        {

            var ville = await _villeService.RecupererVille(id);

            if (ville is null)
            {
                return NotFound("Ville introuvable !");
            }

            return Ok(ville);
        }

        // PUT: api/Villes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> ModifierVille(int id, Ville ville )
        {

             var result = await _villeService.ModifierVille(id, ville);
            if (result is null)
                return NotFound("Ville introuvable");
            return Ok(result);
 

        }

        // POST: api/Villes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Ville>> AjouterVille(Ville ville)
        {
            var result = await _villeService.AjouterVille(ville);
            if (result is null)
                return NotFound("Ville introuvable");
            return Ok(result);
        }

        // DELETE: api/Villes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> SupprimerVille(int id)
        {
           var result = await _villeService.SupprimerVille(id);
            if (result is null)
                return NotFound("Ville introuvable");
            return Ok(result);
        }


    }
}
