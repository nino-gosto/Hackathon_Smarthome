using Hakaton.Application.Interfaces;
using Hakaton.Core;
using Hakaton.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Hakaton.Api
{
    public class DevicesController : BaseCrudController<DeviceDto, DeviceUpsertDto, BaseSearchObject, IDevicesService>
    {
        public DevicesController(IDevicesService service, ILogger<DevicesController> logger) : base(service, logger)
        {
        }

        [HttpGet("ByRoom")]
        public async Task<IActionResult> GetCount([FromQuery] int roomId, CancellationToken cancellationToken = default)
        {
            try
            {
                var count = await Service.GetCountByRoomId(roomId, cancellationToken);
                return Ok(count);
            }
            catch (Exception e)
            {
                Logger.LogError(e, "Error while getting cities by country ID {0}", roomId);
                return BadRequest();
            }
        }

        [HttpGet("GetTotalDevices")]
        public async Task<IActionResult> GetTotalHomes(CancellationToken cancellationToken = default)
        {
            try
            {
                var obj = await Service.GetTotalDevices(cancellationToken);
                return Ok(obj);
            }
            catch (Exception e)
            {
                Logger.LogError(e, "Error while getting total users");
                return BadRequest();
            }
        }
    }
}
