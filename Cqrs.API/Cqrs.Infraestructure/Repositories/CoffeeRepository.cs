using Cqrs.Application.Interfaces.Repositories;
using Cqrs.Application.Models;

namespace Cqrs.Infraestructure.Repositories
{
    public class CoffeeRepository : ICoffeeRepository
    {
        private List<CoffeeModel> _coffees = new ();
        public CoffeeRepository()
        {
            _coffees.Add(new CoffeeModel("Expresso", "Large"));
            _coffees.Add(new CoffeeModel("Latte", "Medium"));
            _coffees.Add(new CoffeeModel("Cappuccino", "Small"));
        }
        public async Task<CoffeeModel> AddAsync(string name, string size)
        {
            CoffeeModel coffee = new(name, size);
            _coffees.Add(coffee);
            return await Task.FromResult(coffee);
        }

        public async Task<List<CoffeeModel>> GetAllAsync()
        {
            return await Task.FromResult(_coffees);
        }
    }
}
