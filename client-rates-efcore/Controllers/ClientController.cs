using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using client_rates_efcore.Model;
using client_rates_efcore.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace client_rates_efcore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly ILogger<ClientController> _logger;
        private readonly IClientService _clientService;

        public ClientController(ILogger<ClientController> logger, IClientService clientService)
        {
            _logger = logger;
            _clientService = clientService;
        }

        [HttpGet]
        public async Task<ActionResult<Client>> GetClientAsync()
        {
            var client = await _clientService.GetAsync();

            return Ok(client.ToString());
        }
    }
}