using Learning.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Learning.Infrastructure.Data.Configurations
{
    public class PropertyConfiguration : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
        }
    }
}
