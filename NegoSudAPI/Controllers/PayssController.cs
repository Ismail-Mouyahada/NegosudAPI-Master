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
using NegoSudAPI.Services.PaysService;

namespace NegoSudAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PayssController : ControllerBase
    {
        private readonly IPaysService _paysService;

        public PayssController(IPaysService paysService)
        {
            _paysService = paysService;
        }

        // GET: api/Payss
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pays>>> RecupererToutPayss()
        {

            return await _paysService.RecupererToutPayss();
        }

        // GET: api/Payss/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pays>> RecupererPays(int id)
        {

            var pays = await _paysService.RecupererPays(id);

            if (pays is null)
            {
                return NotFound("Pays introuvable !");
            }

            return Ok(pays);
        }

        // PUT: api/Payss/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> ModifierPays(int id, Pays pays )
        {

             var result = await _paysService.ModifierPays(id, pays);
            if (result is null)
                return NotFound("Pays introuvable");
            return Ok(result);
 

        }

        // POST: api/Payss
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pays>> AjouterPays(Pays pays)
        {
            var result = await _paysService.AjouterPays(pays);
            if (result is null)
                return NotFound("Pays introuvable");
            return Ok(result);
        }

        // DELETE: api/Payss/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> SupprimerPays(int id)
        {
           var result = await _paysService.SupprimerPays(id);
            if (result is null)
                return NotFound("Pays introuvable");
            return Ok(result);
        }


    }
}
