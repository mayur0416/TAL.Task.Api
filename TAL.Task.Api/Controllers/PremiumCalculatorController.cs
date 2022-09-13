using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TAL.Task.Api.Services;
using TAL.Task.Domains.Models;

namespace TAL.Task.Api.Controllers
{
    [Route("api/premium")]
    [ApiController]
    public class PremiumCalculatorController : ControllerBase
    {
        private readonly ILogger<PremiumCalculatorController> _logger;
        private readonly IPremiumCalculatorService _premiumCalculatorService;

        public PremiumCalculatorController(ILogger<PremiumCalculatorController> logger, IPremiumCalculatorService premiumCalculatorService)
        {
            _logger = logger;
            _premiumCalculatorService = premiumCalculatorService;
        }

        [HttpPost]
        [Route("calculate")]
        public IActionResult GetAllOccupations([FromBody] PremiumCalculatorModel premiumCalculatorModel)
        {
            _logger.LogInformation("calculate premium");
            return this.Ok(_premiumCalculatorService.CalulatePremium(premiumCalculatorModel));
        }
    }
}
