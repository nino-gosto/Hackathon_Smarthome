using Hakaton.Core;
using Hakaton.Infrastructure.Interfaces;

namespace Hakaton.Application.Interfaces
{
    public interface IDeviceActionsService : IBaseService<int, DeviceActionDto, DeviceActionUpsertDto, BaseSearchObject>
    {

    }
}

