using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnIT_ComAp.BussinessLogic;
using UnIT_ComAp.Models;

namespace UnIT_ComAp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly WeatherManager _weatherManager;

        public WeatherForecastController(WeatherManager weatherManager)
        {
            _weatherManager = weatherManager;
        }

        [HttpGet]
        public async Task<ActionResult<Weather>> Get()
        {
            await _weatherManager.InsertWeather();
            return Ok(new Weather());
        }
    }
}
