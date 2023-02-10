using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System.Reflection;

namespace Profit.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMediatR(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
        
    }
}
