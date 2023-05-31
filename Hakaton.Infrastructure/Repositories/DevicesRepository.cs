using Microsoft.EntityFrameworkCore;

using Hakaton.Core;
using Hakaton.Infrastructure.Interfaces;

namespace Hakaton.Infrastructure
{
    public class DevicesRepository : BaseRepository<Device, int, BaseSearchObject>, IDevicesRepository
    {
        public DevicesRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }

        public async Task<int> GetCountByRoomId(int roomId, CancellationToken cancellationToken = default)
        {
            var devices = await DbSet.AsNoTracking().ToListAsync();
            return devices.Count(x => x.RoomId == roomId);
        }

        public async Task<int> GetTotalDevices(CancellationToken cancellationToken = default)
        {
            var devices = await DbSet.AsNoTracking().ToListAsync();
            return devices.Count();
        }
    }
}
