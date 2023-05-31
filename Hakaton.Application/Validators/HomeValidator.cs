using FluentValidation;

using Hakaton.Core;

namespace RideWithMe.Application
{
    public class HomeValidator : AbstractValidator<HomeUpsertDto>
    {
        public HomeValidator()
        {
            RuleFor(c => c.Name).NotNull().NotEmpty();
            RuleFor(c => c.Address).NotNull().NotEmpty();
            RuleFor(c => c.Type).NotNull();
            RuleFor(c => c.UserId).NotNull();
        }
    }
}
