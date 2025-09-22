using BuildingBlocks.CQRS;
using Learning.Application.Data;
using Microsoft.EntityFrameworkCore;

namespace Learning.Application.Queries.Property.GetProperties
{
    public class GetPropertiesQueryHandler(IApplicationDbContext dbContext) : IQueryHandler<GetPropertiesQuery, GetPropertiesResult>
    {
        public async Task<GetPropertiesResult> Handle(GetPropertiesQuery request, CancellationToken cancellationToken)
        {
            var properties = await dbContext.Properties.ToListAsync();

            var result = new GetPropertiesResult(properties);

            return result;
        }
    }
}
