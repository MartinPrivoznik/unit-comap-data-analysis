using System;
using System.Threading.Tasks;
using UnIT_ComAp.Data;
using UnIT_ComAp.Models;
using UnIT_ComAp.Models.DbModel;

namespace UnIT_ComAp.BussinessLogic
{
    public class ReportsManager
    {
        private readonly ReportsDatabase _reportsDatabase;

        public ReportsManager(ReportsDatabase reportsDatabase)
        {
            _reportsDatabase = reportsDatabase;
        }

        public async Task InsertDummy()
        {
            var newHead = await _reportsDatabase.AddAsync<TestHead>(new TestHead() 
            { 
                Id = 0, 
                DateSOfTesting = DateTime.Now,
                Result = new Result() { Success = true },
                Product = new Product()
                {
                    Name = "xxx",
                    SN = "xxx"
                }
            });
        }
    }
}
