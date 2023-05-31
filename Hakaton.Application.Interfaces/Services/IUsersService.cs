using Hakaton.Core;
using Hakaton.Core.Dtos;
using Hakaton.Infrastructure.Interfaces;

namespace Hakaton.Application.Interfaces
{
    public interface IUsersService : IBaseService<int, UserDto, UserUpsertDto, BaseSearchObject>
    {
        Task<UserSensitiveDto?> GetByEmailAsync(string email, CancellationToken cancellationToken = default);
        Task<int> GetCountByUserId(int userId, CancellationToken cancellationToken = default);
        Task<CounterDto> GetTotalUsers(CancellationToken cancellationToken = default);
    }
}
