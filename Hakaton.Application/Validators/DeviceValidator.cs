using FluentValidation;

using Hakaton.Core;

namespace RideWithMe.Application
{
    public class DeviceValidator : AbstractValidator<DeviceUpsertDto>
    {
        public DeviceValidator()
        {
            RuleFor(c => c.Description).NotNull().NotEmpty();
            RuleFor(c => c.DeviceTypeId).NotNull();
            RuleFor(c => c.RoomId).NotNull();
        }
    }
}
