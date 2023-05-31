using Hakaton.Api.Controllers;
using Hakaton.Application.Interfaces;
using Hakaton.Core;
using Hakaton.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Hakaton.Api
{
    public class RoomsController : BaseCrudController<RoomDto, RoomUpsertDto, RoomSearchObject, IRoomsService>
    {
        public RoomsController(IRoomsService service, ILogger<RoomsController> logger) : base(service, logger)
        {
        }

        [HttpGet("ByHome")]
        public async Task<IActionResult> GetCount([FromQuery] int homeId, CancellationToken cancellationToken = default)
        {
            try
            {
                var count = await Service.GetCountByHomeId(homeId, cancellationToken);
                return Ok(count);
            }
            catch (Exception e)
            {
                Logger.LogError(e, "Error while getting cities by country ID {0}", homeId);
                return BadRequest();
            }
        }

        [HttpGet("ByHomeId")]
        public async Task<IActionResult> GetByHomeId([FromQuery] int homeId, CancellationToken cancellationToken = default)
        {
            try
            {
                var rooms = await Service.GetByHomeId(homeId, cancellationToken);
                return Ok(rooms);
            }
            catch (Exception e)
            {
                Logger.LogError(e, "Error while getting rooms by home ID {0}", homeId);
                return BadRequest();
            }
        }
    }
}
