using Microsoft.EntityFrameworkCore;

using Hakaton.Core;
using Hakaton.Infrastructure.Interfaces;

namespace Hakaton.Infrastructure
{
    public class DeviceTypesRepository : BaseRepository<DeviceType, int, DeviceTypeSearchObject>, IDeviceTypesRepository
    {
        public DeviceTypesRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }

        public override Task<PagedList<DeviceType>> GetPagedAsync(DeviceTypeSearchObject searchObject, CancellationToken cancellationToken = default)
        {
            return DbSet
                .Where(d => searchObject.Name == null || d.Name.ToLower().Contains(searchObject.Name.ToLower()))
                .ToPagedListAsync(searchObject, cancellationToken);
        }

        public async Task<int> GetTotalDeviceTypes(CancellationToken cancellationToken = default)
        {
            var types = await DbSet.AsNoTracking().ToListAsync();
            return types.Count();
        }
    }
}
