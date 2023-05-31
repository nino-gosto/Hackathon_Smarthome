using Hakaton.Core;
using Hakaton.Core.Dtos;
using Hakaton.Infrastructure.Interfaces;

namespace Hakaton.Application.Interfaces
{
    public interface IDevicesService : IBaseService<int, DeviceDto, DeviceUpsertDto, BaseSearchObject>
    {
        Task<int> GetCountByRoomId(int roomId, CancellationToken cancellationToken = default);
        Task<CounterDto> GetTotalDevices(CancellationToken cancellationToken = default);
    }
}

