using Hakaton.Core;
using Hakaton.Core.Dtos;
using Hakaton.Infrastructure.Interfaces;

namespace Hakaton.Application.Interfaces
{
    public interface IDeviceTypesService : IBaseService<int, DeviceTypeDto, DeviceTypeUpsertDto, DeviceTypeSearchObject>
    {
        Task<CounterDto> GetTotalDeviceTypes(CancellationToken cancellationToken = default);
    }
}

