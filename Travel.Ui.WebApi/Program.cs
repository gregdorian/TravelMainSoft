
using co.Travel.Application;
using co.Travel.Domain.Repository;
using co.Travel.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using co.Travel.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//*** Inyecion Dependencias de DotNet   ****
builder.Services.AddScoped(typeof(IApplicationService<>), typeof(ApplicationService<>));
//builder.Services.AddScoped(typeof(IfaltaUNO?<>), typeof(faltaUNO?<>));
builder.Services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
builder.Services.AddScoped(typeof(ITokenHandlerService), typeof(TokenHandlerService));

// *** se realiza inyeccion de dependencias al DbContext ***
builder.Services.AddDbContext<TravelDbContext>(opciones => opciones.UseSqlServer("name=dbConnection"));

builder.Services.Configure<JwtConfig>(builder.Configuration.GetSection("JwtConfig"));

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
            .AddJwtBearer(jwt => {
                var key = Encoding.ASCII.GetBytes(builder.Configuration["JwtConfig:Secret"]);

                jwt.SaveToken = true;
                jwt.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    RequireExpirationTime = false,
                    ValidateLifetime = true
                };
            });

builder.Services.AddDefaultIdentity<IdentityUser>(options =>
                        options.SignIn.RequireConfirmedAccount = true)
                       .AddEntityFrameworkStores<TravelDbContext>();

var app = builder.Build();
                     
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
//*** indica middleware esquema de autenticación****
app.UseAuthentication();

app.MapControllers();

app.Run();
