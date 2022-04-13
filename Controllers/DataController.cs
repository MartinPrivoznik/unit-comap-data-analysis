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
    [Route("api")]
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

        [HttpGet("getAll")]
        public ActionResult<IEnumerable<TestHead>> Get()
        {
            return Ok(_reportsManager.GetAllTestData());
        }

        [HttpGet("productNames")]
        public ActionResult<IEnumerable<string>> GetProductNames()
        {
            try
            {
                return Ok(_reportsManager.GetProductNames());
            }
            catch(Exception ex)
            {
                return Conflict(ex);
            }
        }

        [HttpGet("lastTestForEach")]
        public ActionResult<IEnumerable<Test>> GetLastTestForEachDevice()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return Conflict(ex);
            }
        }

        //Data pro jednotlive produkty - posledni test pro sn 
        //Prumerny cas
        //Vsechny testy pro produkt podle nazvu a sn
        //vysledky testu v urcenem obdobi
    }
}
