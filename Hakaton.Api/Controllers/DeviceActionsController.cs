using Hakaton.Api.Controllers;
using Hakaton.Application.Interfaces;
using Hakaton.Core;
using Hakaton.Infrastructure.Interfaces;

namespace Hakaton.Api
{
    public class DeviceActionsController : BaseCrudController<DeviceActionDto, DeviceActionUpsertDto, BaseSearchObject, IDeviceActionsService>
    {
        public DeviceActionsController(IDeviceActionsService service, ILogger<DeviceActionsController> logger) : base(service, logger)
        {
        }
    }
}
