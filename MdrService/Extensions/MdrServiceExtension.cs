using MdrService.Interfaces;
using MdrService.Mapping;
using MdrService.Services;

namespace MdrService.Extensions;

public static class MdrServiceExtension
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddScoped<IElasticsearchService, ElasticsearchService>();
        services.AddScoped<IMdrMapping, MdrMapping>();

        return services;
    }
}