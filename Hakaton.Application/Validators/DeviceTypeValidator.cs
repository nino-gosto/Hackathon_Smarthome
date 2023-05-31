using FluentValidation;

using Hakaton.Core;

namespace RideWithMe.Application
{
    public class DeviceTypeValidator : AbstractValidator<DeviceTypeUpsertDto>
    {
        public DeviceTypeValidator()
        {
            RuleFor(c => c.Name).NotNull().NotEmpty();
        }
    }
}

