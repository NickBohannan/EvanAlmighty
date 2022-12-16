using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace EvanAlmighty.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GenerateGalaxyController : ControllerBase
    {
        private readonly ILogger<GenerateGalaxyController> _logger;

        public GenerateGalaxyController(ILogger<GenerateGalaxyController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Generate([FromQuery(Name = "starNumber")] int starNum)
        {
            Galaxy galaxy = GalaxyGenerator.GenerateGalaxy(starNum);

            string json = JsonConvert.SerializeObject(galaxy);
            return json;
        }
    }
}
