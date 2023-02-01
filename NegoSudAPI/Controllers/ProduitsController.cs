using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NegoSudAPI.Data;
using Microsoft.AspNetCore.Authorization;
using NegoSudAPI.Models;
using Microsoft.AspNetCore.Cors;
using NegoSudAPI.Services;

namespace NegoSudAPI.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProduitController : ControllerBase
    {
        private readonly IProduitService _produitService;

        public ProduitController(IProduitService produitService)
        {
            _produitService = produitService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Produit>>> GetAllProduits()
        {
            var result = _produitService.GetAllProduits();
            if (result is null)
                return NotFound("Produits est introuvable pour l'instant !");
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Produit>>> GetProduit(int id)
        {
            var result = _produitService.GetProduit(id);
            if (result is null)
                return NotFound("Produit est introuvable pour l'instant !");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Produit>>> AddProduit(Produit produit)
        {
            var result = _produitService.AddProduit(produit);
            if (result is null)
                return NotFound("Produit est introuvable pour l'instant !");
            return Ok(result);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<List<Produit>>> UpdateProduit(int id, Produit request)
        {
            var result = _produitService.UpdateProduit(id, request);
            if (result is null)
                return NotFound("Produit est introuvable pour l'instant !");
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Produit>>> DeleteProduit(int id)
        {
            var result = _produitService.DeleteProduit(id);
            if (result is null)
                return NotFound("Produit est introuvable pour l'instant !");
            return Ok(result);
        }
    }
}
