using BuildingBlocks.CQRS;
using FluentValidation;

namespace Learning.Application.Commands.Property.UpdateProperty
{
    public class UpdatePropertyCommand : ICommand<UpdatePropertyResult>
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
    }

    public class UpdatePropertyResult()
    {        
        public bool IsSuccess { get; set; }
    }

    public class UpdatePropertyCommandValidator : AbstractValidator<UpdatePropertyCommand>
    {
        public UpdatePropertyCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
        }
    }

}
