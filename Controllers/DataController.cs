using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnIT_ComAp.BussinessLogic;
using Microsoft.Extensions.DependencyInjection;
using UnIT_ComAp.Models;

namespace UnIT_ComAp.Controllers
{
    [ApiController]
    [Route("weatherforecast")]
    public class DataController : ControllerBase
    {
        private readonly ReportsManager _reportsManager;

        public DataController(ReportsManager reportsManager)
        {
            _reportsManager = reportsManager;
        }

        [HttpGet]
        public async Task<ActionResult<bool>> Get()
        {
            await _reportsManager.InsertDummy();
            return Ok(true);
        }
    }
}
