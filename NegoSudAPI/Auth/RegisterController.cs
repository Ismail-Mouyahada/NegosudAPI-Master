using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using NegoSudAPI.Models;
using NegoSudAPI.Services.UtilisateurService;

namespace NegoSudAPI.Auth
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegisterController : ControllerBase
    {
        private readonly IUtilisateurService _utilisateurService;
        private readonly IConfiguration _configuration;
        public RegisterController(IUtilisateurService utilisateurService, IConfiguration configuration)
        {
            _utilisateurService = utilisateurService;
            _configuration = configuration;

        }
        [EnableCors]
        [HttpPost]
        public IActionResult Inscription(Utilisateur utilisateur)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = _utilisateurService.AjouterUtilisateur(utilisateur);
            if (result is null)
                return NotFound("Utilisateur introuvable");

            return Ok(new
            {
                Message = "Utilisateur a été ajouté avec succès ! ",
                Email = utilisateur.Email,
                MotDePasse = utilisateur.MotDePasse,
                Role = utilisateur.Role

            });
        }
    }
}