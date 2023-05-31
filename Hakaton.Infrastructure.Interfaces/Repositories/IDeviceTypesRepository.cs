using Hakaton.Core;

namespace Hakaton.Infrastructure.Interfaces
{
    public interface IDeviceTypesRepository : IBaseRepository<DeviceType, int, DeviceTypeSearchObject>
    {
        Task<int> GetTotalDeviceTypes(CancellationToken cancellationToken = default);
    }
}

