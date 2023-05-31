using Hakaton.Application.Interfaces;
using Hakaton.Core;
using Hakaton.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Hakaton.Api
{
    public class DeviceTypesController : BaseCrudController<DeviceTypeDto, DeviceTypeUpsertDto, DeviceTypeSearchObject, IDeviceTypesService>
    {
        public DeviceTypesController(IDeviceTypesService service, ILogger<DeviceTypesController> logger) : base(service, logger)
        {
        }

        [HttpGet("GetTotalDeviceTypes")]
        public async Task<IActionResult> GetTotalDeviceTypes(CancellationToken cancellationToken = default)
        {
            try
            {
                var obj = await Service.GetTotalDeviceTypes(cancellationToken);
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
