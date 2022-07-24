using Cqrs.Application.Interfaces.Repositories;
using Cqrs.Infraestructure.Repositories;

namespace Cqrs.API.Configuration
{
    public static class IoCRepositories
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services) 
        {
            services.AddSingleton<ICoffeeRepository, CoffeeRepository>();
            return services;
        }
    }
}
