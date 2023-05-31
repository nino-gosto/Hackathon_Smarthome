using FluentValidation;

using Hakaton.Core;

namespace RideWithMe.Application
{
    public class RoomValidator : AbstractValidator<RoomUpsertDto>
    {
        public RoomValidator()
        {
            RuleFor(c => c.Name).NotNull().NotEmpty();
            RuleFor(c => c.HomeId).NotNull();
        }
    }
}

