using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SeuProjeto.Core.Entities;
using SeuProjeto.Core.Interfaces;

namespace SeuProjeto.Infrastructure.Repositories
{
    public class ProdutoRepositoryFake : IProdutoRepository
    {
        private readonly List<Produto> _produtos = new();
        private int _nextId = 1;

        public ProdutoRepositoryFake()
        {
            // Dados iniciais para teste
            _produtos.Add(new Produto { Id = _nextId++, Nome = "Produto 1", Preco = 10.99m });
            _produtos.Add(new Produto { Id = _nextId++, Nome = "Produto 2", Preco = 20.50m });
        }

        public Task<Produto> ObterPorIdAsync(int id)
        {
            var produto = _produtos.FirstOrDefault(p => p.Id == id);
            return Task.FromResult(produto);
        }

        public Task<IEnumerable<Produto>> ObterTodosAsync()
        {
            return Task.FromResult(_produtos.AsEnumerable());
        }

        public Task AdicionarAsync(Produto produto)
        {
            produto.Id = _nextId++;
            _produtos.Add(produto);
            return Task.CompletedTask;
        }

        public Task AtualizarAsync(Produto produto)
        {
            var index = _produtos.FindIndex(p => p.Id == produto.Id);
            if (index >= 0)
            {
                _produtos[index] = produto;
            }
            return Task.CompletedTask;
        }

        public Task RemoverAsync(int id)
        {
            _produtos.RemoveAll(p => p.Id == id);
            return Task.CompletedTask;
        }
    }
}