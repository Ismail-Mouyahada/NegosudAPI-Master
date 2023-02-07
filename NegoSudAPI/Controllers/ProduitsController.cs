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
using NegoSudAPI.Services.ProduitService;

namespace NegoSudAPI.Controllers
{
     
    [Route("api/[controller]")]
    [ApiController]
    public class ProduitsController : ControllerBase
    {
        private readonly IProduitService _produitService;

        public ProduitsController(IProduitService produitService)
        {
            _produitService = produitService;
        }

        // GET: api/Produits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produit>>> RecupererToutProduits()
        {

            return await _produitService.RecupererToutProduits();
        }

        // GET: api/Produits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Produit>> RecupererProduit(int id)
        {

            var produit = await _produitService.RecupererProduit(id);

            if (produit is null)
            {
                return NotFound("Produit introuvable !");
            }

            return Ok(produit);
        }

        // PUT: api/Produits/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}"),Authorize]
        public async Task<IActionResult> ModifierProduit(int id, Produit produit )
        {

             var result = await _produitService.ModifierProduit(id, produit);
            if (result is null)
                return NotFound("Produit introuvable");
            return Ok(result);
 

        }

        // POST: api/Produits
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost,Authorize]
        public async Task<ActionResult<Produit>> AjouterProduit(Produit produit)
        {
            var result = await _produitService.AjouterProduit(produit);
            if (result is null)
                return NotFound("Produit introuvable");
            return Ok(result);
        }

        // DELETE: api/Produits/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> SupprimerProduit(int id)
        {
           var result = await _produitService.SupprimerProduit(id);
            if (result is null)
                return NotFound("Produit introuvable");
            return Ok(result);
        }


    }
}
