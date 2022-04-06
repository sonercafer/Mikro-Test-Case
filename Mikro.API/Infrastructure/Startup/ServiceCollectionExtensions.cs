using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Mikro.API.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mikro.API.Infrastructure.Startup
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.Scan(scan => scan
                .FromAssemblyOf<IService>()
                .AddClasses(classes => classes.AssignableTo<IService>())
                .AsImplementedInterfaces()
                .WithScopedLifetime());
            return serviceCollection;
        }
    }
}
