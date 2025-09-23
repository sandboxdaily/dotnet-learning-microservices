using Learning.Domain.Abstractions;

namespace Learning.Domain.Models
{
    public class Property : Entity<Guid>
    {
        public string Name { get; set; } = default!;

        public static Property Create(Guid id, string name)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(name);

            var property = new Property
            {
                Id = id,
                Name = name
            };

            return property;
        }        
    }

}
