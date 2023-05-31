using AutoMapper;
using FluentValidation;

using Hakaton.Core;
using Hakaton.Shared.Services;
using Hakaton.Application.Interfaces;
using Hakaton.Infrastructure;
using Hakaton.Infrastructure.Interfaces;
using Hakaton.Core.Dtos;

namespace Hakaton.Application
{
    public class UsersService : BaseService<User, UserDto, UserUpsertDto, BaseSearchObject, IUsersRepository>, IUsersService
    {
        private readonly ICryptoService _cryptoService;

        public UsersService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<UserUpsertDto> validator, ICryptoService cryptoService) : base(mapper, unitOfWork, validator)
        {
            _cryptoService = cryptoService;
        }

        public async Task<UserSensitiveDto?> GetByEmailAsync(string email, CancellationToken cancellationToken = default)
        {
            var user = await CurrentRepository.GetByEmailAsync(email, cancellationToken);

            return Mapper.Map<UserSensitiveDto>(user);
        }

        public override async Task<UserDto> AddAsync(UserUpsertDto dto, CancellationToken cancellationToken = default)
        {
            await ValidateAsync(dto, cancellationToken);

            var entity = Mapper.Map<User>(dto);

            entity.PasswordSalt = _cryptoService.GenerateSalt();
            entity.PasswordHash = _cryptoService.GenerateHash(dto.Password!, entity.PasswordSalt);


            await CurrentRepository.AddAsync(entity, cancellationToken);
            await UnitOfWork.SaveChangesAsync(cancellationToken);
            return Mapper.Map<UserDto>(entity);
        }

        public async Task<int> GetCountByUserId(int userId, CancellationToken cancellationToken = default)
        {
            var count = await CurrentRepository.GetByIdAsync(userId, cancellationToken);

            return Mapper.Map<int>(count);
        }

        public async Task<CounterDto> GetTotalUsers(CancellationToken cancellationToken = default)
        {
            var n = await CurrentRepository.GetTotalUsers();
            var obj = new CounterDto() { CounterValue = n };
            return obj;
        }
    }
}
