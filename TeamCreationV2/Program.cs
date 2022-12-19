using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using TeamCreationV2.Domain.Mappings;
using TeamCreationV2.Infra.Data;
using TeamCreationV2.Infra.Interfaces;
using TeamCreationV2.Infra.Repositories;
using TeamCreationV2.Services.Interfaces.Services;
using TeamCreationV2.Services.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(opt =>opt
                              .UseSqlServer("Data Source=DESKTOP-I618E02;Initial Catalog=Team;Integrated Security=True;TrustServerCertificate = True"));

builder.Services.AddScoped<ITeamServices, TeamServices>();
builder.Services.AddScoped<ITeamRepository,TeamRepository>();

builder.Services.AddScoped<IPersonServices, PersonServices>();
builder.Services.AddScoped<IPersonsRepository, PersonRepository>();

builder.Services.AddAutoMapper(typeof(EntitesToDTO)); //AutoMapper

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme) //JWT
    .AddJwtBearer(opt => {
        opt.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidIssuer = "https://localhost:7290/",
            ValidAudience = "https://localhost:7290/",
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("2oAb3eP0gCbDhWwkFKev9poUhJtQDp2WNI2PGhDR"))
        };
    });
builder.Services.AddMvc();
builder.Services.AddRazorPages();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
 
app.UseAuthentication(); 

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
