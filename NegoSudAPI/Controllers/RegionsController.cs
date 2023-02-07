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
using NegoSudAPI.Services.RegionService;

namespace NegoSudAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly IRegionService _regionService;

        public RegionsController(IRegionService regionService)
        {
            _regionService = regionService;
        }

        // GET: api/Regions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Region>>> RecupererToutRegions()
        {

            return await _regionService.RecupererToutRegions();
        }

        // GET: api/Regions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Region>> RecupererRegion(int id)
        {

            var region = await _regionService.RecupererRegion(id);

            if (region is null)
            {
                return NotFound("Region introuvable !");
            }

            return Ok(region);
        }

        // PUT: api/Regions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> ModifierRegion(int id, Region region )
        {

             var result = await _regionService.ModifierRegion(id, region);
            if (result is null)
                return NotFound("Region introuvable");
            return Ok(result);
 

        }

        // POST: api/Regions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Region>> AjouterRegion(Region region)
        {
            var result = await _regionService.AjouterRegion(region);
            if (result is null)
                return NotFound("Region introuvable");
            return Ok(result);
        }

        // DELETE: api/Regions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> SupprimerRegion(int id)
        {
           var result = await _regionService.SupprimerRegion(id);
            if (result is null)
                return NotFound("Region introuvable");
            return Ok(result);
        }


    }
}
