using BuildingBlocks.CQRS;

namespace Learning.Application.Queries.Property.GetProperties
{
    public class GetPropertiesQuery : IQuery<GetPropertiesResult>
    {

    }

    public class GetPropertiesResult
    {
        public IEnumerable<Domain.Models.Property> Properties { get; set; } = default!;

        public GetPropertiesResult(IEnumerable<Domain.Models.Property> properties)
        {
            this.Properties = properties;
        }
    }

    
}
