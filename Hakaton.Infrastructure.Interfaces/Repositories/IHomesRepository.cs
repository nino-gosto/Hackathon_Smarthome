using Hakaton.Core;

namespace Hakaton.Infrastructure.Interfaces
{
    public interface IHomesRepository : IBaseRepository<Home, int, BaseSearchObject>
    {
        Task<IEnumerable<Home>> GetByUserId(int userId, CancellationToken cancellationToken = default);
        Task<int> GetTotalHomes(CancellationToken cancellationToken = default);

    }
}

