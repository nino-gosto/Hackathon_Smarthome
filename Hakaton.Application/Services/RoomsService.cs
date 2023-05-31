using AutoMapper;
using FluentValidation;

using Hakaton.Core;
using Hakaton.Shared.Services;
using Hakaton.Application.Interfaces;
using Hakaton.Infrastructure;
using Hakaton.Infrastructure.Interfaces;
using System.Collections.Generic;

namespace Hakaton.Application
{
    public class RoomsService : BaseService<Room, RoomDto, RoomUpsertDto, RoomSearchObject, IRoomsRepository>, IRoomsService
    {
        public RoomsService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<RoomUpsertDto> validator) : base(mapper, unitOfWork, validator)
        {

        }

        public async Task<IEnumerable<RoomDto>> GetByHomeId(int homeId, CancellationToken cancellationToken = default)
        {
            var rooms = await CurrentRepository.GetByHomeId(homeId, cancellationToken);

            return Mapper.Map<IEnumerable<RoomDto>>(rooms);
        }

        public async Task<int> GetCountByHomeId(int homeId, CancellationToken cancellationToken = default)
        {
            var count = await CurrentRepository.GetCountByHomeId(homeId, cancellationToken);

            return Mapper.Map<int>(count);
        }
    }
}
