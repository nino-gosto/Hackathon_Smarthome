using Microsoft.EntityFrameworkCore;

using Hakaton.Core;
using Hakaton.Infrastructure.Interfaces;

namespace Hakaton.Infrastructure
{
    public class UsersRepository : BaseRepository<User, int, BaseSearchObject>, IUsersRepository
    {
        public UsersRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }

        public async Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken = default)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(u => u.Email == email, cancellationToken);
        }

        public async Task<int> GetCountByUserId(int userId, CancellationToken cancellationToken = default)
        {
            return await DbSet.AsNoTracking().Where(h => h.Id == userId).Select(h => h.Homes.Count()).FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<int> GetTotalUsers(CancellationToken cancellationToken = default)
        {
            return await DbSet.Where(u => u.Role == Role.Parent || u.Role == Role.Child).CountAsync(cancellationToken);
        }
    }
}
