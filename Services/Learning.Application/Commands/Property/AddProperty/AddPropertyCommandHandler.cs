using BuildingBlocks.CQRS;
using Learning.Application.Data;

namespace Learning.Application.Commands.Property.AddProperty
{
    public class AddPropertyCommandHandler(IApplicationDbContext dbContext) : ICommandHandler<AddPropertyCommand, AddPropertyResult>
    {
        public async Task<AddPropertyResult> Handle(AddPropertyCommand request, CancellationToken cancellationToken)
        {
            // Implementation here

            var property = this.AddNewProperty(request);

            dbContext.Properties.Add(property);
            await dbContext.SaveChangesAsync(cancellationToken);

            return new AddPropertyResult();
        }

        private Domain.Models.Property AddNewProperty(AddPropertyCommand request)
        {
            var t = new Domain.Models.Property();
            t.Name = request.Name;

            return t;
        }
    }
}
