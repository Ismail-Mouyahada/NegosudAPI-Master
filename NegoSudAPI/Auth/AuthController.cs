
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using NegoSudAPI.Data;
using NegoSudAPI.Models;
using NegoSudAPI.Auth;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.AspNetCore.Cors;

namespace NegoSudAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly NegosudDbContext _context;
        private readonly IConfiguration _configuration;
        public AuthController(NegosudDbContext context, IConfiguration configuration)
        {
            _context =context;
            _configuration = configuration;

        }
        [EnableCors]
        [HttpPost]
        public IActionResult Connexion(UtilisateurAuth  utilisateur )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            // Check if the user Existes
            var user = _context.utilisateurs.FirstOrDefault(u => u.Email == utilisateur.Email && u.MotDePasse == new PasswordHash().HashedPass(utilisateur.MotDePasse));
            if (user == null)
            {
                return Unauthorized("Des identifiants invalides ou introuvable");
            }

            // Create token

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, utilisateur.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

            var signingCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddDays(7),
                signingCredentials: signingCredentials
                );
            return Ok(new
            {
                Access_Token = new JwtSecurityTokenHandler().WriteToken(token),
                Date_Expiration = DateTime.Now.AddDays(7),
                Nom_uilisateur = utilisateur.Email,
                Mot_De_passe = new PasswordHash().HashedPass(utilisateur.MotDePasse),


            });
        }

         


    }
}
