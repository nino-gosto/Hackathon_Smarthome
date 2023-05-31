using Microsoft.EntityFrameworkCore;

using Hakaton.Core;
using Hakaton.Infrastructure.Interfaces;

namespace Hakaton.Infrastructure
{
    public class DeviceActionsRepository : BaseRepository<DeviceAction, int, BaseSearchObject>, IDeviceActionsRepository
    {
        public DeviceActionsRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }
    }
}
