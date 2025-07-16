using TaskApi.Core.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using TaskApi.Infrastructure.Persistence.Repositories;
using TaskApi.Infrastructure.TestsDoubles.Fakes;

namespace TaskApi.Infrastructure.Extensions
{
    public static class InfrastructureServiceCollection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<ITaskRepository, FakeTaskRepository>();

            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }

    }
}