using Application.Features.Brands.Commands.Create;
using FluentValidation;

namespace Application.Features.Commands.Create
{
    public class CreateBrandCommandValidator : AbstractValidator<CreateBrandCommand>
    {
        public CreateBrandCommandValidator()
        {
            RuleFor(i => i.Name).NotEmpty();
            RuleFor(i => i.Name).MinimumLength(2); // >2 || >=2 MG
        }
    }
}
