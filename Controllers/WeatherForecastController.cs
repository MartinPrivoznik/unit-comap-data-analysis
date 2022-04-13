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
    public class DataController : ControllerBase
    {
        private readonly WeatherManager _weatherManager;

        public DataController(WeatherManager weatherManager)
        {
            _weatherManager = weatherManager;
        }

        [HttpGet]
        public async Task<ActionResult<bool>> Get()
        {
            await _weatherManager.InsertWeather();
            return Ok(true);
        }
    }
}
