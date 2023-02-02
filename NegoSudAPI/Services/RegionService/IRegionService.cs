
using NegoSudAPI.Models;


namespace NegoSudAPI.Services.RegionService
{
    public interface IRegionService
    {
        Task<List<Region>> RecupererToutRegions();
        Task<Region?> RecupererRegion(int id);
        Task<List<Region>> AjouterRegion(Region Region);
        Task<List<Region>?> ModifierRegion(int id, Region request);
        Task<List<Region>?> SupprimerRegion(int id);
    }
}