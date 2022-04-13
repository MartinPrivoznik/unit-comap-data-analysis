using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnIT_ComAp.Models.DbModel
{
    public class TestHead
    {
        public string Id { get; set; }
        public string ProductName { get; set; }
        public string ProductSN { get; set; }
        public bool Success { get; set; }
        public DateTime DateSOfTesting { get; set; }
        public float TestTime { get; set; }
        public string TesterInfo { get; set; }
        public string UserName { get; set; }
        public string IniSecurity { get; set; }

        [NotMapped]
        public IEnumerable<TestGroup> TestGroups { get; set; }
    }
}
