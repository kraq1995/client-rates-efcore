using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace client_rates_efcore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RatesController : Controller
    {
        private readonly ILogger<RatesController> _logger;
        public RatesController(ILogger<RatesController> logger)
        {
            _logger = logger;
        }

        [HttpGet("id/{id}")]
        public IActionResult GetById(int id)
        {

            return Ok();
        }

        [HttpPost]
        public IActionResult AddRate()
        {
            return Ok();
        }

        [HttpPatch]
        public IActionResult EditRate()
        {
            return Accepted();
        }

        [HttpDelete]
        public IActionResult DeleteRate()
        {
            return Accepted();
        }

    }
}