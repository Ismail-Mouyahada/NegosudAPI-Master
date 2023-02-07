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
using NegoSudAPI.Services.ElemFactureService;

namespace NegoSudAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ElemFacturesController : ControllerBase
    {
        private readonly IElemFactureService _elemfactureService;

        public ElemFacturesController(IElemFactureService elemfactureService)
        {
            _elemfactureService = elemfactureService;
        }

        // GET: api/ElemFactures
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ElemFacture>>> RecupererToutElemFactures()
        {

            return await _elemfactureService.RecupererToutElemFactures();
        }

        // GET: api/ElemFactures/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ElemFacture>> RecupererElemFacture(int id)
        {

            var elemfacture = await _elemfactureService.RecupererElemFacture(id);

            if (elemfacture is null)
            {
                return NotFound("ElemFacture introuvable !");
            }

            return Ok(elemfacture);
        }

        // PUT: api/ElemFactures/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> ModifierElemFacture(int id, ElemFacture elemfacture )
        {

             var result = await _elemfactureService.ModifierElemFacture(id, elemfacture);
            if (result is null)
                return NotFound("ElemFacture introuvable");
            return Ok(result);
 

        }

        // POST: api/ElemFactures
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ElemFacture>> AjouterElemFacture(ElemFacture elemfacture)
        {
            var result = await _elemfactureService.AjouterElemFacture(elemfacture);
            if (result is null)
                return NotFound("ElemFacture introuvable");
            return Ok(result);
        }

        // DELETE: api/ElemFactures/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> SupprimerElemFacture(int id)
        {
           var result = await _elemfactureService.SupprimerElemFacture(id);
            if (result is null)
                return NotFound("ElemFacture introuvable");
            return Ok(result);
        }


    }
}
