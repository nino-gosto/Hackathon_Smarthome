using AutoMapper;
using FluentValidation;

using Hakaton.Core;
using Hakaton.Shared.Services;
using Hakaton.Application.Interfaces;
using Hakaton.Infrastructure;
using Hakaton.Infrastructure.Interfaces;

namespace Hakaton.Application
{
    public class DeviceActionsService : BaseService<DeviceAction, DeviceActionDto, DeviceActionUpsertDto, BaseSearchObject, IDeviceActionsRepository>, IDeviceActionsService
    {
        public DeviceActionsService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<DeviceActionUpsertDto> validator) : base(mapper, unitOfWork, validator)
        {

        }
    }
}
