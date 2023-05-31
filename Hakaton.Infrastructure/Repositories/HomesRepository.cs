using Microsoft.EntityFrameworkCore;

using Hakaton.Core;
using Hakaton.Infrastructure.Interfaces;
using System.Collections.Immutable;

namespace Hakaton.Infrastructure
{
    public class HomesRepository : BaseRepository<Home, int, BaseSearchObject>, IHomesRepository
    {
        public HomesRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }

        public async Task<IEnumerable<Home>> GetByUserId(int userId, CancellationToken cancellationToken = default)
        {
            var homes = await DbSet.AsNoTracking().Where(h => h.UserId == userId).ToListAsync();

            return homes;
        }

        public async Task<int> GetTotalHomes(CancellationToken cancellationToken = default)
        {
            var homes = await DbSet.AsNoTracking().ToListAsync();
            return homes.Count();
        }
    }
}
