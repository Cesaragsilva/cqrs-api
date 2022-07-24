using Cqrs.Application.Commands;
using Cqrs.Application.Interfaces.Repositories;
using Cqrs.Application.Models;
using MediatR;

namespace Cqrs.Application.Handlers.Command
{
    public class AddCoffeeHandler : IRequestHandler<AddCoffee, CoffeeModel>
    {
        private readonly ICoffeeRepository _coffeeRepository;
        public AddCoffeeHandler(ICoffeeRepository coffeeRepository)
        {
            _coffeeRepository = coffeeRepository;
        }
        public async Task<CoffeeModel> Handle(AddCoffee request, CancellationToken cancellationToken)
        {
            return await _coffeeRepository.AddAsync(request.name, request.size);
        }
    }
}
