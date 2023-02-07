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
using NegoSudAPI.Services.FournisseurService;

namespace NegoSudAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class FournisseursController : ControllerBase
    {
        private readonly IFournisseurService _produitService;

        public FournisseursController(IFournisseurService produitService)
        {
            _produitService = produitService;
        }

        // GET: api/Fournisseurs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fournisseur>>> RecupererToutFournisseurs()
        {

            return await _produitService.RecupererToutFournisseurs();
        }

        // GET: api/Fournisseurs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Fournisseur>> RecupererFournisseur(int id)
        {

            var produit = await _produitService.RecupererFournisseur(id);

            if (produit is null)
            {
                return NotFound("Fournisseur introuvable !");
            }

            return Ok(produit);
        }

        // PUT: api/Fournisseurs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> ModifierFournisseur(int id, Fournisseur produit )
        {

             var result = await _produitService.ModifierFournisseur(id, produit);
            if (result is null)
                return NotFound("Fournisseur introuvable");
            return Ok(result);
 

        }

        // POST: api/Fournisseurs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Fournisseur>> AjouterFournisseur(Fournisseur produit)
        {
            var result = await _produitService.AjouterFournisseur(produit);
            if (result is null)
                return NotFound("Fournisseur introuvable");
            return Ok(result);
        }

        // DELETE: api/Fournisseurs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> SupprimerFournisseur(int id)
        {
           var result = await _produitService.SupprimerFournisseur(id);
            if (result is null)
                return NotFound("Fournisseur introuvable");
            return Ok(result);
        }


    }
}
