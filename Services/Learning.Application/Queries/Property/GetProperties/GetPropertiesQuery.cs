using BuildingBlocks.CQRS;
using BuildingBlocks.Pagination;

namespace Learning.Application.Queries.Property.GetProperties
{
    public class GetPropertiesQuery : IQuery<GetPropertiesResult>
    {
        public PaginationRequest PaginationRequest { get; set; }

    }

    public class GetPropertiesResult
    {
        public PaginationResult<Domain.Models.Property> Properties { get; set; } = default!;

        public GetPropertiesResult(PaginationResult<Domain.Models.Property> properties)
        {
            this.Properties = properties;
        }
    }

    
}
