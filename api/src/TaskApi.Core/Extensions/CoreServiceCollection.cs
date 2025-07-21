using Microsoft.Extensions.DependencyInjection;
using TaskApi.Core.Application.Interfaces;
using TaskApi.Core.Application.Services;

namespace TaskApi.Core.Extensions
{
    public static class CoreServiceCollection
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(DutyProfile).Assembly);

            services.AddSingleton<IDutyService, DutyService>();

            services.AddSingleton<IUserService, UserService>();

            return services;
        }
    }
}