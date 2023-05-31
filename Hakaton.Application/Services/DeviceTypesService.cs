using AutoMapper;
using FluentValidation;

using Hakaton.Core;
using Hakaton.Shared.Services;
using Hakaton.Application.Interfaces;
using Hakaton.Infrastructure;
using Hakaton.Infrastructure.Interfaces;
using Hakaton.Core.Dtos;

namespace Hakaton.Application
{
    public class DeviceTypesService : BaseService<DeviceType, DeviceTypeDto, DeviceTypeUpsertDto, DeviceTypeSearchObject, IDeviceTypesRepository>, IDeviceTypesService
    {
        public DeviceTypesService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<DeviceTypeUpsertDto> validator) : base(mapper, unitOfWork, validator)
        {

        }

        public async Task<CounterDto> GetTotalDeviceTypes(CancellationToken cancellationToken = default)
        {
            var n = await CurrentRepository.GetTotalDeviceTypes();
            var obj = new CounterDto() { CounterValue = n };
            return obj;
        }
    }
}
