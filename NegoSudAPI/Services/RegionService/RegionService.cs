
using NegoSudAPI.Data;
using NegoSudAPI.Models;
using Microsoft.EntityFrameworkCore;
 

namespace NegoSudAPI.Services.RegionService
{ public class RegionService : IRegionService
    {
        private readonly NegosudDbContext _context;

        public RegionService(NegosudDbContext context)
        {
            _context = context;
        }

        public async Task<List<Region>> AjouterRegion(Region region)
        {
             if (_context.regions == null)
            {
                throw new ArgumentNullException(nameof(_context.regions), "tout est vide.");
            }
              _context.regions.Add(region);
            await _context.SaveChangesAsync();
            return await _context.regions.ToListAsync();
        }
        public async Task<List<Region>?> SupprimerRegion(int id)
        {
            if (_context.regions == null)
            {
                throw new ArgumentNullException(nameof(_context.regions), "tout est vide.");
            }
            var region = await _context.regions.FindAsync(id);
            if (region is null)
                return null;

            _context.regions.Remove(region);
            await _context.SaveChangesAsync();

            return await _context.regions.ToListAsync();
        }

        public   Task<List<Region>> RecupererToutRegions()
        {
            if (_context.regions == null)
            {
                throw new ArgumentNullException(nameof(_context.regions), "tout est vide.");
            }
            var regions =   _context.regions.ToListAsync();
            return regions;
        }

        public async Task<Region?> RecupererRegion(int id)
        {
            if (_context.regions == null)
            {
                throw new ArgumentNullException(nameof(_context.regions), "tout est vide.");
            }
            var region = await _context.regions.FindAsync(id);
            if (region is null)
                return null;

            return region;
        }

        public async Task<List<Region>?> ModifierRegion(int id, Region request)
        {
            if (_context.regions == null)
            {
                throw new ArgumentNullException(nameof(_context.regions), "tout est vide.");
            }
            var region = await _context.regions.FindAsync(id);
            if (region is null)
                return null;

            region.NameRegion = request.NameRegion;
            region.PaysId = request.PaysId;
            

            await _context.SaveChangesAsync();

            return await _context.regions.ToListAsync();
        }

        
    }
}
