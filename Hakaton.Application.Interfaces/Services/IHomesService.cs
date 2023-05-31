using Hakaton.Core;
using Hakaton.Core.Dtos;
using Hakaton.Infrastructure.Interfaces;

namespace Hakaton.Application.Interfaces
{
    public interface IHomesService : IBaseService<int, HomeDto, HomeUpsertDto, BaseSearchObject>
    {
        Task<IEnumerable<Home>> GetByUserId(int userId, CancellationToken cancellationToken = default);
        Task<CounterDto> GetTotalHomes(CancellationToken cancellationToken = default);

    }
}

