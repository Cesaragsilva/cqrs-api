namespace Cqrs.Application.Models
{
    public class CoffeeModel
    {
        public CoffeeModel(string name, string size)
        {
            Id = Guid.NewGuid();
            Name = name;
            Size = size;
        }

        public Guid Id { get; set; } 
        public string Name { get; set; }
        public string Size { get; set; }
    }
}
