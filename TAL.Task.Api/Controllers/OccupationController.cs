using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TAL.Task.Api.Services;

namespace TAL.Task.Api.Controllers
{
    [Route("api/occupation")]
    [Produces("application/json")]
    [ApiController]
    public class OccupationController : ControllerBase
    {
        private readonly ILogger<OccupationController> _logger;
        private readonly IOccupationService _occupationService;

        public OccupationController(ILogger<OccupationController> logger, IOccupationService occupationService)
        {
            _logger = logger;
            _occupationService = occupationService;
        }

        [HttpGet]
        [Route("getalloccupations")]
        public IActionResult GetAllOccupations()
        {
            _logger.LogInformation("get all occupations");
            return this.Ok(_occupationService.GetOccupationsList());
        }
    }
}
