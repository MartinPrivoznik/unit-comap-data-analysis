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
using Test = UnIT_ComAp.Models.DbModel.Test;

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

        public IEnumerable<object> GetProductNames()
        {
            return _reportsDatabase.TestHeads
                .ToList()
                .GroupBy(head => head.ProductName)
                .Select(head =>  head.FirstOrDefault().ProductName);
        }


        public IEnumerable<TestHead> GetLastTestsBySn(string deviceName)
        {
            return _reportsDatabase.TestHeads
                .Where(head => head.ProductName == deviceName)
                .OrderByDescending(head => head.DateSOfTesting)
                .ToList()
                .GroupBy(head => head.ProductSN)
                .Select(head => head.FirstOrDefault());
        }

        public IEnumerable<TestGroup> GetAllTestGroupsForDevice(string deviceName, string deviceSn)
        {
            var head = _reportsDatabase.TestHeads
                .Where(head => head.ProductName == deviceName && head.ProductSN == deviceSn)
                .FirstOrDefault();

            return _reportsDatabase.TestGroups
                .Where(grp => grp.HeadId == head.Id);
        }

        public IEnumerable<Test> GetAllTestsForGroup(string deviceName, string deviceSn, long groupId)
        {
            var head = _reportsDatabase.TestHeads
                .Where(head => head.ProductName == deviceName && head.ProductSN == deviceSn)
                .FirstOrDefault();

            var group = _reportsDatabase.TestGroups
                .Where(grp => grp.HeadId == head.Id && grp.Id == groupId)
                .FirstOrDefault();

            var tests = _reportsDatabase.Tests
                .Where(tst => tst.HeadId == head.Id && tst.GroupId == group.Id)
                .ToList();

            foreach(var tst in tests)
            {
                tst.TestOperations = _reportsDatabase.TestOperations.Where(op => op.TestId == tst.Id && op.HeadId == head.Id && op.GroupId == group.Id);
            }

            return tests;
        }

        public Task InsertData()
        {
            return Task.Run(() =>
            {
                var files = Directory.GetFiles(@"C:\Development\unit-comap-data-analysis\reports\PG24D\");

                foreach (var fileName in files)
                {
                    string headGuid = Guid.NewGuid().ToString();
                    XmlSerializer serializer = new XmlSerializer(typeof(Test_report));
                    using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
                    {
                        Test_report report = (Test_report)serializer.Deserialize(fileStream);

                        var head = new TestHead()
                        {
                            Id = headGuid,
                            ProductName = report.Head.Product.Name,
                            ProductSN = report.Head.Product.Sfidstring,
                            DateSOfTesting = DateTime.Parse(report.Head.Timestamp.Value),
                            Success = report.Head.Result.Value == "PASS",
                            TestTime = float.Parse(report.Head.Testtotaltime.Value),
                            TesterInfo = report.Head.Testerinfo.Value,
                            IniSecurity = report.Head.Inisecurity.Value,
                            UserName = report.Head.Username.Value
                        };

                        _reportsDatabase.Add(head);

                        long j = 1;

                        foreach (var grp in report.Test_set.Group)
                        {
                            var group = new TestGroup()
                            {
                                Id = j,
                                HeadId = headGuid,
                                Success = grp.Result == "PASS",
                                Title = grp.Title
                            };

                            _reportsDatabase.Add(group);

                            long i = 1;

                            foreach (var tst in grp.Test)
                            {
                                var test = new Models.DbModel.Test()
                                {
                                    Id = i,
                                    GroupId = j,
                                    HeadId = headGuid,
                                    Title = tst.Title
                                };

                                _reportsDatabase.Add(test);

                                long k = 1;

                                foreach (var op in tst.Operations.Check)
                                {
                                    var operation = new TestOperation()
                                    {
                                        Id = k,
                                        HeadId = headGuid,
                                        GroupId = j,
                                        TestId = i,
                                        Name = op.Name,
                                        Type = "check",
                                        Value = op.Value,
                                        ExpectedLow = op.Expectedlow,
                                        ExpectedHigh = op.Expectedhigh,
                                        Expected = op.Expected,
                                        Result = op.Result,
                                        Side = op.Side
                                    };

                                    k++;
                                    _reportsDatabase.Add(operation);
                                }

                                foreach (var op in tst.Operations.Info)
                                {
                                    var operation = new TestOperation()
                                    {
                                        Id = k,
                                        HeadId = headGuid,
                                        GroupId = j,
                                        TestId = i,
                                        Text = op._Text
                                    };

                                    k++;
                                    _reportsDatabase.Add(operation);
                                }
                                i++;
                            }
                            j++;
                        }
                        _reportsDatabase.SaveChanges();
                    }
                }
            });
        }
    }
}
