using Hakaton.Core;
using Hakaton.Infrastructure.Interfaces;

namespace Hakaton.Application.Interfaces
{
    public interface IRoomsService : IBaseService<int, RoomDto, RoomUpsertDto, RoomSearchObject>
    {
        Task<int> GetCountByHomeId(int homeId, CancellationToken cancellationToken = default);
        Task<IEnumerable<RoomDto>> GetByHomeId(int homeId, CancellationToken cancellationToken = default);
    }
}

