using Microsoft.EntityFrameworkCore;
using CompraApi.Models;
using CompraApi.Data;
using CompraApi.Services.interfaces;
using CompraApi.Services.Produto;
using CompraApi.Services.Condicoe;

var builder = WebApplication.CreateBuilder(args);

// Adiciona o serviço do DbContext com a conexão SQLite
builder.Services.AddDbContext<DadosCompras>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Adicionar os repositórios e serviços
builder.Services.AddScoped<IProdutoInterface, ProdutoService>();
builder.Services.AddScoped<ICondicoesInterface, CondicoesService>();

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
app.UseAuthorization(); // Se você tiver autenticação/autorização

// Mapeia os endpoints dos controladores
app.MapControllers();

app.Run();
