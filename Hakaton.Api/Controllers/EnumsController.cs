using Microsoft.AspNetCore.Mvc;

using Hakaton.Common.Services;

namespace Hakaton.Api.Controllers
{
    public class EnumsController : BaseController
    {
        private readonly IEnumsService _enumsService;

        public EnumsController(IEnumsService enumsService, ILogger<EnumsController> logger) : base(logger)
        {
            _enumsService = enumsService;
        }

        [HttpGet("roles")]
        [ResponseCache(VaryByHeader = "User-Agent", Duration = 3600)]
        public async Task<IActionResult> GetRoles() => Ok(await _enumsService.GetRolesAsync());

        [HttpGet("home-types")]
        [ResponseCache(VaryByHeader = "User-Agent", Duration = 3600)]
        public async Task<IActionResult> GerHomeTypes() => Ok(await _enumsService.GetHomesTypesAsync());
    }
}
