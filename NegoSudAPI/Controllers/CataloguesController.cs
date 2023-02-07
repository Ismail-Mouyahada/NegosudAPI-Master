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
            var path = catalogue.Image;

            if (!Path.IsPathRooted(catalogue.Image))
            {

                var fileName = Path.GetFileName(catalogue.Image);

                if (fileName == null || fileName == "")
                {
                    throw new ArgumentException("Image must be");
                }
                path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", fileName);

                var webClient = new WebClient();

                webClient.DownloadFile(catalogue.Image, path);

            }

            var uploadsDirectory = Path.GetDirectoryName(path);
            if (!Directory.Exists(uploadsDirectory))
            {
                if (uploadsDirectory == null)
                {
                    throw new ArgumentException();
                }
                Directory.CreateDirectory(uploadsDirectory);
            }

            if (path == null)
            {
                throw new ArgumentException();
            }

            using (var stream = new FileStream(path, FileMode.Create))
            {

                await _catalogueService.AjouterCatalogue(catalogue);
            }

            if (path == null)
                return NotFound("Catalogue introuvable");

            return Ok(path);
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
