using FluentValidation;

using Hakaton.Core;

namespace RideWithMe.Application
{
    public class DeviceActionValidator : AbstractValidator<DeviceActionUpsertDto>
    {
        public DeviceActionValidator()
        {
            RuleFor(c => c.SettingName).NotNull().NotEmpty();
            RuleFor(c => c.SettingValue).NotNull().NotEmpty();
            RuleFor(c => c.StartTime).NotNull();
            RuleFor(c => c.EndTime).NotNull();
            RuleFor(c => c.DeviceId).NotNull();
            RuleFor(c => c.UserId).NotNull();
        }
    }
}
