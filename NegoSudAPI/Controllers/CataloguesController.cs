using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NegoSudAPI.Data;
using System.IO;
using NegoSudAPI.Models;
using Microsoft.AspNetCore.Authorization;
using NegoSudAPI.Services.CatalogueService;
using System.Net;

namespace NegoSudAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CataloguesController : ControllerBase
    {
        private readonly ICatalogueService _catalogueService;

        public CataloguesController(ICatalogueService catalogueService)
        {
            _catalogueService = catalogueService;
        }

        // GET: api/Catalogues
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Catalogue>>> RecupererToutCatalogues()
        {

            return await _catalogueService.RecupererToutCatalogues();
        }

        // GET: api/Catalogues/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Catalogue>> RecupererCatalogue(int id)
        {

            var catalogue = await _catalogueService.RecupererCatalogue(id);

            if (catalogue is null)
            {
                return NotFound("Catalogue introuvable !");
            }

            return Ok(catalogue);
        }

        // PUT: api/Catalogues/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> ModifierCatalogue(int id, Catalogue catalogue)
        {

            var result = await _catalogueService.ModifierCatalogue(id, catalogue);
            if (result is null)
                return NotFound("Catalogue introuvable");
            return Ok(result);


        }

        // POST: api/Catalogues
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Catalogue>> AjouterCatalogue(Catalogue catalogue)
        {
            var fileName = Path.GetFileName(catalogue.Image);

            if (string.IsNullOrEmpty(fileName))
            {
                return BadRequest("Image must be specified");
            }

            var uploadsDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
            if (!Directory.Exists(uploadsDirectory))
            {
                Directory.CreateDirectory(uploadsDirectory);
            }

            var path = Path.Combine(uploadsDirectory, fileName);

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(catalogue.Image, HttpCompletionOption.ResponseHeadersRead))
                {
                    response.EnsureSuccessStatusCode();
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await response.Content.CopyToAsync(fileStream);
                    }
                }
            }

            await _catalogueService.AjouterCatalogue(catalogue);

            return Ok();
        }

        // DELETE: api/Catalogues/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> SupprimerCatalogue(int id)
        {
            var result = await _catalogueService.SupprimerCatalogue(id);
            if (result is null)
                return NotFound("Catalogue introuvable");
            return Ok(result);
        }
    }
}
