using Cqrs.Application.Models;
using MediatR;

namespace Cqrs.Application.Queries
{
    public record GetCoffeeById(Guid Id) : IRequest<CoffeeModel>;
}
