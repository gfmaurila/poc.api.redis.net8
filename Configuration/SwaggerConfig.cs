using Microsoft.OpenApi.Models;

namespace poc.api.redis.Configuration;

public static class SwaggerConfig
{
    public static IServiceCollection AddSwaggerConfig(this IServiceCollection services, IConfiguration conf)
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc(
                "v1",
                new OpenApiInfo
                {
                    Title = "Loja teste",
                    Version = "v1"
                }
            );
        });
        return services;
    }
}
