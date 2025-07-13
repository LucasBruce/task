using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TaskApi.Core.Application.Interfaces;
using TaskApi.Core.Application.Services;
using TaskApi.Infrastructure.Persistence.Repositories;

namespace TaskApi.Compose;

public static class CompositionConfig
{
    public static IServiceCollection ComposeApplication(
            this IServiceCollection services,
            IConfiguration configuration)
    {
        services.AddScoped<ITaskRepository, TaskRepository>();

        services.AddScoped<IUserRepository, UserRepository>();

        services.AddScoped<ITaskService, TaskService>();

        services.AddScoped<IUserService, UserService>();

        return services;
    }
}
