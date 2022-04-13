using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnIT_ComAp.Data;
using UnIT_ComAp.Models;
using UnIT_ComAp.Models.DbModel;
using UnIT_ComAp.Models.Schemes;

namespace UnIT_ComAp.BussinessLogic
{
    public class ReportsManager
    {
        private readonly ReportsDatabase _reportsDatabase;

        public ReportsManager(ReportsDatabase reportsDatabase)
        {
            _reportsDatabase = reportsDatabase;
        }

        public IEnumerable<TestHead> GetAllTestData()
        {
            var head = _reportsDatabase.TestHeads.ToArray();

            foreach (var hd in head)
            {
                hd.TestGroups = _reportsDatabase.TestGroups.Where(grp => grp.HeadId == hd.Id).ToArray();

                foreach (var grp in hd.TestGroups)
                {
                    grp.Tests = _reportsDatabase.Tests.Where(tst => tst.HeadId == hd.Id && tst.GroupId == grp.Id).ToArray();

                    foreach (var tst in grp.Tests)
                    {
                        tst.TestOperations = _reportsDatabase.TestOperations.Where(op => op.HeadId == hd.Id && op.GroupId == grp.Id && op.TestId == tst.Id).ToArray();
                    }
                }
            }

            return head;
        }

        public async Task InsertSmart()
        {

            XmlSerializer serializer = new XmlSerializer(typeof(Object));
            using (FileStream fileStream = new FileStream("C:/Users/petrp/OneDrive/Plocha/IL4_PG24A21510A00_FAIL_PART1_04a1dbd7-d657-4078-9df7-aff4f41152aa.xml", FileMode.Open))
            {
                Head testHead = (Head)serializer.Deserialize(fileStream);
                Group testGroup = (Group)serializer.Deserialize(fileStream);
                Models.Schemes.Test test = (Models.Schemes.Test)serializer.Deserialize(fileStream);
                Operations testOperations = (Operations)serializer.Deserialize(fileStream);

                var newHead = new TestHead()
                {
                    Id = 1,
                    DateSOfTesting = DateTime.Parse(testHead.Timestamp.Value),
                    ProductName = testHead.Product.Name,
                    ProductSN = testHead.Product.Sn,
                    Success = testHead.Securitycheck.Value == "PASS" ? true : false
                };

                _reportsDatabase.Add(newHead);

                var newGroup = new TestGroup()
                {
                    Id = int.Parse(testGroup.Groupid),
                    HeadId = newHead.Id,
                    Success = testGroup.Result == "PASS" ? true : false
                };

                _reportsDatabase.Add(newGroup);

                var newTest = new Models.DbModel.Test()
                {
                    Id = int.Parse(test.Testid),
                    HeadId = newHead.Id,
                    GroupId = newGroup.Id,
                    Title = test.Title
                };

                _reportsDatabase.Add(newTest);

                var newTestOperation = new TestOperation()
                {
                    //Id = int.Parse(testOperations.Check),
                    HeadId = newHead.Id,
                    GroupId = newGroup.Id,
                    TestId = newTest.Id,
                    Type = testOperations.Check == null ? "info" : "check",  /* Asi lépe by to chtělo :D */
                    Name = "" //Type check/info raději List
                };

                _reportsDatabase.Add(newTest);
            }
        }
    }
}
