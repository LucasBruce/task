
using SeuProjeto.Core;
using SeuProjeto.Infrastructure;
using SeuProjeto.Api.Extensions;
using SeuProjeto.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Configuração simplificada da DI
// builder.Services.AddCoreServices();
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();

builder.Services.AddInfrastructureServices(); // Agora sem necessidade de configuration

var app = builder.Build();

app.MapProdutoEndpoints();

app.MapPost("/produtos", (Produto produto, IProdutoRepository repo) => 
{
    repo.Adicionar(produto);
    return Results.Created($"/produtos/{produto.Id}", produto);
});

app.Run();