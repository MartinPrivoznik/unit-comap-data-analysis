using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnIT_ComAp.BussinessLogic;
using Microsoft.Extensions.DependencyInjection;
using UnIT_ComAp.Models;
using UnIT_ComAp.Models.DbModel;

namespace UnIT_ComAp.Controllers
{
    [ApiController]
    [Route("data")]
    public class DataController : ControllerBase
    {
        private readonly ReportsManager _reportsManager;

        public DataController(ReportsManager reportsManager)
        {
            _reportsManager = reportsManager;
        }

        [HttpGet("init")]
        public async Task<ActionResult<bool>> Init()
        {
            await _reportsManager.InsertData();
            return true;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TestHead>> Get()
        {
            //_reportsManager.InsertData();
            return Ok(_reportsManager.GetAllTestData());
            //return Ok(_reportsManager.GetAllTestData());
        }
    }
}
