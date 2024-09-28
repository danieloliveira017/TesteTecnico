using Microsoft.EntityFrameworkCore;
using CompraApi.Models;
using CompraApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Adiciona o serviço do DbContext com a conexão SQLite
builder.Services.AddDbContext<DadosCompras>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Adiciona os serviços de controladores
builder.Services.AddControllers();

// Configura o Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configura o pipeline de requisições HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();



app.Run();
