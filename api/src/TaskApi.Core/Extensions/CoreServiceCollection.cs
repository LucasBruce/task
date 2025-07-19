using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using TaskApi.Core.Application.Interfaces;
using TaskApi.Core.Application.Mappings;
using TaskApi.Core.Application.Services;

namespace TaskApi.Core.Extensions
{
    public static class CoreServiceCollection
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperUser), typeof(AutoMapperDuty));

            services.AddSingleton<IDutyService, DutyService>();

            services.AddSingleton<IUserService, UserService>();

            return services;
        }
    }
}