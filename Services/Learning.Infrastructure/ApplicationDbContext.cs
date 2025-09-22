using Learning.Application.Data;
using Learning.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Learning.Infrastructure
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options) { }
        public DbSet<Property> Properties => Set<Property>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
    }
}
