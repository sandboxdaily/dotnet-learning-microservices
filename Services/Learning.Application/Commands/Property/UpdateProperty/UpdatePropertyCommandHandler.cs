using BuildingBlocks.CQRS;
using FluentValidation;
using Learning.Application.Data;

namespace Learning.Application.Commands.Property.UpdateProperty
{
    public class UpdatePropertyCommandHandler(IApplicationDbContext dbContext) : ICommandHandler<UpdatePropertyCommand, UpdatePropertyResult>
    {
        public async Task<UpdatePropertyResult> Handle(UpdatePropertyCommand request, CancellationToken cancellationToken)
        {
            // Implementation here

            var property = await dbContext.Properties.FindAsync(request.Id);

            if (property == null)
                throw new ValidationException("Property not found");               

            property.Name = request.Name;

            dbContext.Properties.Update(property);
            await dbContext.SaveChangesAsync(cancellationToken);

            return new UpdatePropertyResult();
        }
    }
}
