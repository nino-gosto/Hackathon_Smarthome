using Hakaton.Core;

namespace Hakaton.Infrastructure.Interfaces
{
    public interface IDevicesRepository : IBaseRepository<Device, int, BaseSearchObject>
    {
        Task<int> GetCountByRoomId(int roomId, CancellationToken cancellationToken = default);
        Task<int> GetTotalDevices(CancellationToken cancellationToken = default);
    }
}

