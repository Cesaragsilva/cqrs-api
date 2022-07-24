using Cqrs.Application.Interfaces.Repositories;
using Cqrs.Application.Models;
using Cqrs.Application.Queries;
using MediatR;

namespace Cqrs.Application.Handlers.Queries
{
    public class GetCoffeeListHandler : IRequestHandler<GetCoffeeList, List<CoffeeModel>>
    {
        private readonly ICoffeeRepository _coffeeRepository;
        public GetCoffeeListHandler(ICoffeeRepository coffeeRepository)
        {
            _coffeeRepository = coffeeRepository;
        }
        public async Task<List<CoffeeModel>> Handle(GetCoffeeList request, CancellationToken cancellationToken)
        {
            return await _coffeeRepository.GetAllAsync();
        }
    }
}
