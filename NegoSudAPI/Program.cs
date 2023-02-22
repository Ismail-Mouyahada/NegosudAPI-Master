using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using NegoSudAPI.Data;
using NegoSudAPI.Services.ProduitService;
using NegoSudAPI.Services.UtilisateurService;
using NegoSudAPI.Services.CategorieService;
using NegoSudAPI.Services.CatalogueService;
using NegoSudAPI.Services.AdresseService;
using NegoSudAPI.Services.FactureService;
using NegoSudAPI.Services.ElemFactureService;
using NegoSudAPI.Services.CommandeService;
using NegoSudAPI.Services.ElemCommandeService;
using NegoSudAPI.Services.FournisseurService;
using NegoSudAPI.Services.ProducteurService;
using NegoSudAPI.Services.InventaireService;
using NegoSudAPI.Services.MagasinService;
using NegoSudAPI.Services.RegionService;
using NegoSudAPI.Services.PaysService;
using NegoSudAPI.Services.VilleService;
using NegoSudAPI.Services.MailerService;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var ConnectionToMysqlStr = builder.Configuration.GetConnectionString("MySQLConntectionStr");

        builder.Services.AddControllers();

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // Injecting Services into the container using main Scope
        builder.Services.AddScoped<IUtilisateurService, UtilisateurService>();
        builder.Services.AddScoped<ICategorieService, CategorieService>();
        builder.Services.AddScoped<ICatalogueService, CatalogueService>();
        builder.Services.AddScoped<IAdresseService, AdresseService>();
        builder.Services.AddScoped<IFactureService, FactureService>();
        builder.Services.AddScoped<IElemFactureService, ElemFactureService>();
        builder.Services.AddScoped<ICommandeService, CommandeService>();
        builder.Services.AddScoped<IElemCommandeService, ElemCommandeService>();
        builder.Services.AddScoped<IFournisseurService, FournisseurService>();
        builder.Services.AddScoped<IProducteurService, ProducteurService>();
        builder.Services.AddScoped<IInventaireService, InventaireService>();
        builder.Services.AddScoped<IMagasinService, MagasinService>();
        builder.Services.AddScoped<IRegionService, RegionService>();
        builder.Services.AddScoped<IPaysService, PaysService>();
        builder.Services.AddScoped<IVilleService, VilleService>();
        builder.Services.AddScoped<IProduitService, ProduitService>();
        builder.Services.AddScoped<IMailerService, MailerService>();

        //Add Swagger Authentification field to Swagger UI
        builder.Services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "NeoSud REST API",
                Description = "Making coding fun with CESI challenges.This API was developed for educational propuses.",
                Version = "v1",
            });
            options.AddSecurityRequirement(
                new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                },
                new string[]{}
                },
        });
            options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                In = ParameterLocation.Header,
                Description = "Insert JWT Token",
                Name = "Authorization",
                Type = SecuritySchemeType.Http,
                BearerFormat = "JWT",
                Scheme = "Bearer"
            });
        });
        // Authentification with JWT
        builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
        {
            if (builder.Configuration["Jwt:APIKey"] == null)
            {
                throw new ArgumentNullException("tout est vide.");
            }
            options.TokenValidationParameters = new TokenValidationParameters()
            {
                ClockSkew = TimeSpan.Zero,
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = builder.Configuration["Jwt:Issuer"],
                ValidAudience = builder.Configuration["Jwt:Audience"],
                IssuerSigningKey = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(builder.Configuration["Jwt:APIKey"])
                ),
            };
        });
        //Adding the DB context
        builder.Services.AddDbContext<NegosudDbContext>(options =>
        {
            options.UseMySql(ConnectionToMysqlStr, ServerVersion.AutoDetect(ConnectionToMysqlStr));
        });

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        //app.UseHttpsRedirection(); // To Set up for  real project
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthentication();
        app.UseAuthorization();
        app.MapControllers();
        app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
        //app.MapAdresseEndpoints();

        app.Run("http://localhost:8000"); // To Set up for  real project
    }
}