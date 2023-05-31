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
    public class HomesSevice : BaseService<Home, HomeDto, HomeUpsertDto, BaseSearchObject, IHomesRepository>, IHomesService
    {
        public HomesSevice(IMapper mapper, IUnitOfWork unitOfWork, IValidator<HomeUpsertDto> validator) : base(mapper, unitOfWork, validator)
        {

        }

        public async Task<IEnumerable<Home>> GetByUserId(int userId, CancellationToken cancellationToken = default)
        {
            var homes = await CurrentRepository.GetByUserId(userId, cancellationToken);

            return homes;
        }

        public async Task<CounterDto> GetTotalHomes(CancellationToken cancellationToken = default)
        {
            var n = await CurrentRepository.GetTotalHomes();
            var obj = new CounterDto() { CounterValue = n };
            return obj;
        }
    }
}
