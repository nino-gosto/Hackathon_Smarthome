using Hakaton.Api.Controllers;
using Hakaton.Application.Interfaces;
using Hakaton.Core;
using Hakaton.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Hakaton.Api
{
    public class UsersController : BaseCrudController<UserDto, UserUpsertDto, BaseSearchObject, IUsersService>
    {
        public UsersController(IUsersService service, ILogger<UsersController> logger) : base(service, logger)
        {
        }

        [HttpGet("ByHomes")]
        public async Task<IActionResult> GetCount([FromQuery] int userId, CancellationToken cancellationToken = default)
        {
            try
            {
                var count = await Service.GetByIdAsync(userId, cancellationToken);
                return Ok(count);
            }
            catch (Exception e)
            {
                Logger.LogError(e, "Error while getting cities by country ID {0}", userId);
                return BadRequest();
            }
        }

        [HttpGet("GetTotalUsers")]
        public async Task<IActionResult> GetTotalUsers(CancellationToken cancellationToken = default)
        {
            try
            {
                var obj = await Service.GetTotalUsers(cancellationToken);
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
