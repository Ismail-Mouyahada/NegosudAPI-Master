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
using NegoSudAPI.Services.MagasinService;

namespace NegoSudAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MagasinsController : ControllerBase
    {
        private readonly IMagasinService _magasinService;

        public MagasinsController(IMagasinService magasinService)
        {
            _magasinService = magasinService;
        }

        // GET: api/Magasins
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Magasin>>> RecupererToutMagasins()
        {

            return await _magasinService.RecupererToutMagasins();
        }

        // GET: api/Magasins/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Magasin>> RecupererMagasin(int id)
        {

            var magasin = await _magasinService.RecupererMagasin(id);

            if (magasin is null)
            {
                return NotFound("Magasin introuvable !");
            }

            return Ok(magasin);
        }

        // PUT: api/Magasins/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> ModifierMagasin(int id, Magasin magasin )
        {

             var result = await _magasinService.ModifierMagasin(id, magasin);
            if (result is null)
                return NotFound("Magasin introuvable");
            return Ok(result);
 

        }

        // POST: api/Magasins
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Magasin>> AjouterMagasin(Magasin magasin)
        {
            var result = await _magasinService.AjouterMagasin(magasin);
            if (result is null)
                return NotFound("Magasin introuvable");
            return Ok(result);
        }

        // DELETE: api/Magasins/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> SupprimerMagasin(int id)
        {
           var result = await _magasinService.SupprimerMagasin(id);
            if (result is null)
                return NotFound("Magasin introuvable");
            return Ok(result);
        }


    }
}
