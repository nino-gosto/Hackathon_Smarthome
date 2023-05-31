using Hakaton.Core;

namespace Hakaton.Infrastructure.Interfaces
{
    public interface IRoomsRepository : IBaseRepository<Room, int, RoomSearchObject>
    {
        Task<int> GetCountByHomeId(int homeId, CancellationToken cancellationToken = default);
        Task<IEnumerable<Room>> GetByHomeId(int homeId, CancellationToken cancellationToken = default);

    }
}

