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
using NegoSudAPI.Services.ProducteurService;

namespace NegoSudAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProducteursController : ControllerBase
    {
        private readonly IProducteurService _producteurService;

        public ProducteursController(IProducteurService producteurService)
        {
            _producteurService = producteurService;
        }

        // GET: api/Producteurs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producteur>>> RecupererToutProducteurs()
        {

            return await _producteurService.RecupererToutProducteurs();
        }

        // GET: api/Producteurs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Producteur>> RecupererProducteur(int id)
        {

            var producteur = await _producteurService.RecupererProducteur(id);

            if (producteur is null)
            {
                return NotFound("Producteur introuvable !");
            }

            return Ok(producteur);
        }

        // PUT: api/Producteurs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> ModifierProducteur(int id, Producteur producteur )
        {

             var result = await _producteurService.ModifierProducteur(id, producteur);
            if (result is null)
                return NotFound("Producteur introuvable");
            return Ok(result);
 

        }

        // POST: api/Producteurs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Producteur>> AjouterProducteur(Producteur producteur)
        {
            var result = await _producteurService.AjouterProducteur(producteur);
            if (result is null)
                return NotFound("Producteur introuvable");
            return Ok(result);
        }

        // DELETE: api/Producteurs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> SupprimerProducteur(int id)
        {
           var result = await _producteurService.SupprimerProducteur(id);
            if (result is null)
                return NotFound("Producteur introuvable");
            return Ok(result);
        }


    }
}
