using Hakaton.Core;

namespace Hakaton.Infrastructure.Interfaces
{
    public interface IUsersRepository : IBaseRepository<User, int, BaseSearchObject>
    {
        Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken = default);
        Task<int> GetCountByUserId(int userId, CancellationToken cancellationToken = default);
        Task<int> GetTotalUsers(CancellationToken cancellationToken = default);
    }
}
