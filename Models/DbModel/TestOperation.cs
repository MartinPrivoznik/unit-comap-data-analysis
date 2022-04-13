using System.ComponentModel.DataAnnotations;

namespace UnIT_ComAp.Models.DbModel
{
    public class TestOperation
    {
        [Key]
        public int HeadId { get; set; }
        [Key]
        public int GroupId { get; set; }
        [Key]
        public string TestId { get; set; }

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
