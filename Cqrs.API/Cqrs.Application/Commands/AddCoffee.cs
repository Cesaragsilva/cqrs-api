using Cqrs.Application.Models;
using MediatR;

namespace Cqrs.Application.Commands
{
    public record AddCoffee(string name, string size) : IRequest<CoffeeModel>;
}
