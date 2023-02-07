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
using NegoSudAPI.Services.CategorieService;

namespace NegoSudAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategorieService _categorieService;

        public CategoriesController(ICategorieService categorieService)
        {
            _categorieService = categorieService;
        }

        // GET: api/Categories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categorie>>> RecupererToutCategories()
        {

            return await _categorieService.RecupererToutCategories();
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Categorie>> RecupererCategorie(int id)
        {

            var categorie = await _categorieService.RecupererCategorie(id);

            if (categorie is null)
            {
                return NotFound("Categorie introuvable !");
            }

            return Ok(categorie);
        }

        // PUT: api/Categories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> ModifierCategorie(int id, Categorie categorie )
        {

             var result = await _categorieService.ModifierCategorie(id, categorie);
            if (result is null)
                return NotFound("Categorie introuvable");
            return Ok(result);
 

        }

        // POST: api/Categories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Categorie>> AjouterCategorie(Categorie categorie)
        {
            var result = await _categorieService.AjouterCategorie(categorie);
            if (result is null)
                return NotFound("Categorie introuvable");
            return Ok(result);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> SupprimerCategorie(int id)
        {
           var result = await _categorieService.SupprimerCategorie(id);
            if (result is null)
                return NotFound("Categorie introuvable");
            return Ok(result);
        }


    }
}
