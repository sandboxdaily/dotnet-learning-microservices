using BuildingBlocks.CQRS;
using FluentValidation;

namespace Learning.Application.Commands.Property.AddProperty
{
    public class AddPropertyCommand : ICommand<AddPropertyResult>
    {
        public string Name { get; set; }
    }

    public class AddPropertyResult()
    {
        public Guid? Id { get; set; }
        public bool IsSuccess { get; set; }
    }

    public class AddPropertyCommandValidator : AbstractValidator<AddPropertyCommand>
    {
        public AddPropertyCommandValidator()
        {
            RuleFor(x => x).NotEmpty().WithMessage("Name is required");
        }
    }

}
