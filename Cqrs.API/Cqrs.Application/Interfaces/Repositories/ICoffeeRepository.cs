using Cqrs.Application.Models;

namespace Cqrs.Application.Interfaces.Repositories
{
    public interface ICoffeeRepository
    {
        Task<List<CoffeeModel>> GetAllAsync();
        Task<CoffeeModel> AddAsync(string name, string size);
    }
}
