using System;
using System.ComponentModel.DataAnnotations;

namespace UnIT_ComAp.Models.DbModel
{
    public class TestOperation
    {
        public int Id { get; set; }
        public Guid HeadId { get; set; }
        public int GroupId { get; set; }
        public int TestId { get; set; }

        public string Type { get; set; }

        //Type == check
        public string Name { get; set; }
        public string Value { get; set; }
        public string Result { get; set; }
        public string ExpectedHigh { get; set; }
        public string ExpectedLow { get; set; }

        //Type == info
        public string Text { get; set; }
    }
}
