using TaskApi.Core.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using TaskApi.Infrastructure.TestsDoubles.Fakes;

namespace TaskApi.Infrastructure.Extensions
{
    public static class InfrastructureServiceCollection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<IDutyRepository, FakeDutyRepository>();

            services.AddSingleton<IUserRepository, FakeUserRepository>();

            return services;
        }

    }
}