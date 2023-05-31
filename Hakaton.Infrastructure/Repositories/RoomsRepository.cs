using Microsoft.EntityFrameworkCore;

using Hakaton.Core;
using Hakaton.Infrastructure.Interfaces;

namespace Hakaton.Infrastructure
{
    public class RoomsRepository : BaseRepository<Room, int, RoomSearchObject>, IRoomsRepository
    {
        public RoomsRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }

        public async Task<IEnumerable<Room>> GetByHomeId(int homeId, CancellationToken cancellationToken = default)
        {
            return await DbSet.AsNoTracking().Where(e => e.HomeId == homeId).ToListAsync();
        }

        public async Task<int> GetCountByHomeId(int homeId, CancellationToken cancellationToken = default)
        {
            var rooms = await DbSet.AsNoTracking().ToListAsync();
            return rooms.Count(x => x.HomeId == homeId);
        }

        public override Task<PagedList<Room>> GetPagedAsync(RoomSearchObject searchObject, CancellationToken cancellationToken = default)
        {
            return DbSet
                .Where(r => searchObject.HomeId == null || r.HomeId == searchObject.HomeId)
                .ToPagedListAsync(searchObject, cancellationToken);
        }
    }
}
