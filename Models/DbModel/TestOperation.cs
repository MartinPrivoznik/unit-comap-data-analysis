using System;
using System.ComponentModel.DataAnnotations;

namespace UnIT_ComAp.Models.DbModel
{
    public class TestOperation
    {
        public long Id { get; set; }
        public long HeadId { get; set; }
        public long GroupId { get; set; }
        public long TestId { get; set; }

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
