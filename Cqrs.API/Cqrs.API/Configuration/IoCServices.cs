using Cqrs.Application.Interfaces.Repositories;
using MediatR;

namespace Cqrs.API.Configuration
{
    public static class IoCServices
    {
        public static IServiceCollection AddServices(this IServiceCollection services) 
        {
            services.AddMediatR(typeof(ICoffeeRepository).Assembly);
            return services;
        }
    }
}
