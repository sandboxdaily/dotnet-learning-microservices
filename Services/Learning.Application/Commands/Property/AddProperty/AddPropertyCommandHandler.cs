using BuildingBlocks.CQRS;

namespace Learning.Application.Commands.Property.AddProperty
{
    public class AddPropertyCommandHandler: ICommandHandler<AddPropertyCommand, AddPropertyResult>
    {
        public async Task<AddPropertyResult> Handle(AddPropertyCommand request, CancellationToken cancellationToken)
        {
            // Implementation here

            return new AddPropertyResult();
        }
    }
}
