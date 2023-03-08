
using co.Travel.Abstraction;
using co.Travel.Application;
using co.Travel.Domain.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(typeof(IApplicationService<>), typeof(ApplicationService<>));
builder.Services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));

// *** se realiza inyeccion de dependencias al DbContext ***
//builder.Services.AddDbContext<TravelDbContext>(opciones =>
//    opciones.UseSqlServer("name=dbConnection"));

var app = builder.Build();
                     
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
