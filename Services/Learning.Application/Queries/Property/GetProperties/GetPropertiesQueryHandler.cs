using BuildingBlocks.CQRS;
using BuildingBlocks.Pagination;
using Learning.Application.Data;
using Microsoft.EntityFrameworkCore;

namespace Learning.Application.Queries.Property.GetProperties
{
    public class GetPropertiesQueryHandler(IApplicationDbContext dbContext) : IQueryHandler<GetPropertiesQuery, GetPropertiesResult>
    {
        public async Task<GetPropertiesResult> Handle(GetPropertiesQuery request, CancellationToken cancellationToken)
        {

            var pageIndex = request.PaginationRequest.PageIndex;
            var pageSize = request.PaginationRequest.PageSize;
            var totalCount = await dbContext.Properties.LongCountAsync(cancellationToken);

            var properties = await dbContext.Properties
                .Skip(pageSize * pageIndex)
                .Take(pageSize)
                .ToListAsync(cancellationToken);

            var result = new GetPropertiesResult(
                new PaginationResult<Domain.Models.Property>(
                    pageIndex, 
                    pageSize, 
                    totalCount, 
                    properties.ToList())
                );

            return result;
        }
    }
}
