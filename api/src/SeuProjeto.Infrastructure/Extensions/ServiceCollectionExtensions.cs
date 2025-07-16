using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using SeuProjeto.Core.Interfaces; // Ajuste conforme o namespace real da interface
using SeuProjeto.Infrastructure.Repositories; // Ajuste conforme o namespace real da classe

namespace SeuProjeto.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            // Registrar o repositório fake
            services.AddSingleton<IProdutoRepository, ProdutoRepositoryFake>();

            return services;
        }
    }
}