
using Microsoft.Extensions.Configuration;
using TaskApi.Core.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using TaskApi.Infrastructure.Persistence.Repositories;

namespace TaskApi.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            
            services.AddScoped<ITaskRepository, TaskRepository>();

            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }

    }
}