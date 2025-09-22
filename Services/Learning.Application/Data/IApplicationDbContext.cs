using Learning.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Learning.Application.Data
{
    public interface IApplicationDbContext
    {
        DbSet<Property> Properties { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
