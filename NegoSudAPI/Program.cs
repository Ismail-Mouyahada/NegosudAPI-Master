using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using NegoSudAPI.Data;
using NegoSudAPI.Models;
using NegoSudAPI.Services;
using WebApplication2.Services.ProduitService;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var ConnectionToMysqlStr = builder.Configuration.GetConnectionString("MySQLConntectionStr");

        // Add services to the container.
        builder.Services.AddCors(options =>
        {
            options.AddPolicy(name: "PolicyOfCors",
                            policy =>
                            {
                                policy.WithOrigins("http://localhost:8000");
                            });
        });
        builder.Services.AddControllers();

     
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // Injecting Services into the container using main Scope  
        builder.Services.AddScoped<IProduitService, ProduitService>();
        
        
        builder.Services.AddSwaggerGen(options =>
        {

            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "NeoSud REST API",
                Description = "Making coding fun with CESI challenges.This API was deceloped for educational propses.",
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
        builder.Services .AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                }).AddJwtBearer(options =>
            {
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
                        Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])
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

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthentication();
        app.UseAuthorization();
        app.MapControllers();
        app.UseCors("PolicyOfCors");
        //app.MapAdresseEndpoints();

        app.Run("http://localhost:8000");
    }
}