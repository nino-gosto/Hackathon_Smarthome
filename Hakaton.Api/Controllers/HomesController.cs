using Hakaton.Api.Controllers;
using Hakaton.Application.Interfaces;
using Hakaton.Core;
using Hakaton.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Hakaton.Api
{
    public class HomesController : BaseCrudController<HomeDto, HomeUpsertDto, BaseSearchObject, IHomesService>
    {
        public HomesController(IHomesService service, ILogger<HomesController> logger) : base(service, logger)
        {
        }

        [HttpGet("ByUser")]
        public async Task<IActionResult> GetCount([FromQuery] int userId, CancellationToken cancellationToken = default)
        {
            try
            {
                var homes = await Service.GetByUserId(userId, cancellationToken);
                return Ok(homes);
            }
            catch (Exception e)
            {
                Logger.LogError(e, "Error while getting cities by country ID {0}", userId);
                return BadRequest();
            }
        }

        [HttpGet("GetTotalHomes")]
        public async Task<IActionResult> GetTotalHomes(CancellationToken cancellationToken = default)
        {
            try
            {
                var obj = await Service.GetTotalHomes(cancellationToken);
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
