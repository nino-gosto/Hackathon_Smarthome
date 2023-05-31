using FluentValidation;

using Hakaton.Core;

namespace RideWithMe.Application
{
    public class UserValidator : AbstractValidator<UserUpsertDto>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotNull().NotEmpty();
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.Email).NotNull().NotEmpty()
                                 .EmailAddress();

            RuleFor(u => u.Password)
                .NotEmpty()
                .NotNull()
                .MinimumLength(8)
                .Matches(@"[A-Z]+")
                .Matches(@"[a-z]+")
                .Matches(@"[0-9]+")
                .When(u => u.Id == null || u.Password != null);

            RuleFor(u => u.PhoneNumber).NotEmpty().NotEmpty();
            RuleFor(u => u.IsVerified).NotNull();
            RuleFor(u => u.IsActive).NotNull();
        }
    }
}

