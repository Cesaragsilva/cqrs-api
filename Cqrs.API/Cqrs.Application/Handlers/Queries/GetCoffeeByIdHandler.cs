using Cqrs.Application.Models;
using Cqrs.Application.Queries;
using MediatR;

namespace Cqrs.Application.Handlers.Queries
{
    public class GetCoffeeByIdHandler : IRequestHandler<GetCoffeeById, CoffeeModel>
    {
        private readonly IMediator _mediator;
        public GetCoffeeByIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<CoffeeModel> Handle(GetCoffeeById request, CancellationToken cancellationToken)
        {
            var coffees = await _mediator.Send(new GetCoffeeList());
            var searched = coffees.FirstOrDefault(x => x.Id == request.Id);
            return searched;
        }
    }
}
