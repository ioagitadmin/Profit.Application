using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Profit.Core;
using Profit.Core.Mapping;
using Profit.Infrastructure.Database;
using System.Reflection;

namespace Profit.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connection = configuration.GetConnectionString("Postgres");
            services.AddDbContext<ApplicationContext>(options => options.UseNpgsql(connection));
            services.AddScoped<IApplicationContext>(provider => provider.GetService<ApplicationContext>());

            return services;
        }

        public static IServiceCollection AddMapper(this IServiceCollection services, Assembly assembly)
        {
            services.AddAutoMapper(config =>
            {
                config.AddProfile(new MappingProfile(assembly));
                config.AddProfile(new MappingProfile(typeof(IApplicationContext).Assembly));
            });

            return services;
        }
    }
}
