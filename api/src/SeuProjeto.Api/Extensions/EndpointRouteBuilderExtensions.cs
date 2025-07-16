using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeuProjeto.Api.Extensions
{
    public static class EndpointRouteBuilderExtensions
    {
        public static IEndpointRouteBuilder MapProdutoEndpoints(this IEndpointRouteBuilder app)
        {
            var grupo = app.MapGroup("/api/produtos")
                .WithTags("Produtos");

            grupo.MapGet("/", async (IProdutoRepository repo) =>
                await repo.ObterTodosAsync());

            grupo.MapGet("/{id}", async (int id, IProdutoRepository repo) =>
            {
                var produto = await repo.ObterPorIdAsync(id);
                return produto is not null ? Results.Ok(produto) : Results.NotFound();
            });

            grupo.MapPost("/", async (Produto produto, IProdutoRepository repo) =>
            {
                await repo.AdicionarAsync(produto);
                return Results.Created($"/api/produtos/{produto.Id}", produto);
            });

            grupo.MapPut("/{id}", async (int id, Produto produto, IProdutoRepository repo) =>
            {
                if (id != produto.Id)
                    return Results.BadRequest();

                await repo.AtualizarAsync(produto);
                return Results.NoContent();
            });

            grupo.MapDelete("/{id}", async (int id, IProdutoRepository repo) =>
            {
                await repo.RemoverAsync(id);
                return Results.NoContent();
            });

            return app;
        }
    }
}