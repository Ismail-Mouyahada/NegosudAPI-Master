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
using NegoSudAPI.Services.AdresseService;

namespace NegoSudAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AdressesController : ControllerBase
    {
        private readonly IAdresseService _adresseService;

        public AdressesController(IAdresseService adresseService)
        {
            _adresseService = adresseService;
        }

        // GET: api/Adresses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Adresse>>> RecupererToutAdresses()
        {

            return await _adresseService.RecupererToutAdresses();
        }

        // GET: api/Adresses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Adresse>> RecupererAdresse(int id)
        {

            var adresse = await _adresseService.RecupererAdresse(id);

            if (adresse is null)
            {
                return NotFound("Adresse introuvable !");
            }

            return Ok(adresse);
        }

        // PUT: api/Adresses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> ModifierAdresse(int id, Adresse adresse )
        {

             var result = await _adresseService.ModifierAdresse(id, adresse);
            if (result is null)
                return NotFound("Adresse introuvable");
            return Ok(result);
 

        }

        // POST: api/Adresses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Adresse>> AjouterAdresse(Adresse adresse)
        {
            var result = await _adresseService.AjouterAdresse(adresse);
            if (result is null)
                return NotFound("Adresse introuvable");
            return Ok(result);
        }

        // DELETE: api/Adresses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> SupprimerAdresse(int id)
        {
           var result = await _adresseService.SupprimerAdresse(id);
            if (result is null)
                return NotFound("Adresse introuvable");
            return Ok(result);
        }


    }
}
