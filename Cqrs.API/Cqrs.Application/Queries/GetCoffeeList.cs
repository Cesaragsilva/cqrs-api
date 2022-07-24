using Cqrs.Application.Models;
using MediatR;

namespace Cqrs.Application.Queries
{
    public record GetCoffeeList() : IRequest<List<CoffeeModel>>;
}
