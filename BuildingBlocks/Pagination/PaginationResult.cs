namespace BuildingBlocks.Pagination
{
    public class PaginationResult<TEntity>(int pageIndex, int pageSize, long total, IEnumerable<TEntity> data) where TEntity : class
    {
        public int PageIndex { get; } = pageIndex;
        public int PageSize { get; } = pageSize;
        public long Total { get; } = total;
        public IEnumerable<TEntity> Data { get; } = data;
    }
}
