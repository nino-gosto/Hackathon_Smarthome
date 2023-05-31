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
    public class DevicesService : BaseService<Device, DeviceDto, DeviceUpsertDto, BaseSearchObject, IDevicesRepository>, IDevicesService
    {
        public DevicesService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<DeviceUpsertDto> validator) : base(mapper, unitOfWork, validator)
        {

        }

        public async Task<int> GetCountByRoomId(int roomId, CancellationToken cancellationToken = default)
        {
            var count = await CurrentRepository.GetCountByRoomId(roomId, cancellationToken);

            return Mapper.Map<int>(count);
        }

        public async Task<CounterDto> GetTotalDevices(CancellationToken cancellationToken = default)
        {
            var n = await CurrentRepository.GetTotalDevices();
            var obj = new CounterDto() { CounterValue = n };
            return obj;
        }
    }
}
