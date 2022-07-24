using Cqrs.Application.Commands;
using Cqrs.Application.Models;
using Cqrs.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Cqrs.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/")]
    public class CoffeeController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CoffeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<CoffeeModel>> Get() 
        {
            return await _mediator.Send(new GetCoffeeList());
        }


        [HttpGet("{id}")]
        public async Task<CoffeeModel> Get(Guid id)
        {
            return await _mediator.Send(new GetCoffeeById(id));
        }

        [HttpPost]
        public async Task<CoffeeModel> Post([FromBody] CoffeeModel coffeeModel)
        {
            return await _mediator.Send(new AddCoffee(coffeeModel.Name, coffeeModel.Size));
        }
    }
}
