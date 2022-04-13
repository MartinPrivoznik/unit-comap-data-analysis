using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnIT_ComAp.Models.DbModel
{
    public class TestHead
    {
        public long Id { get; set; }
        public string ProductName { get; set; }
        public string ProductSN { get; set; }
        public bool Success { get; set; }
        public DateTime DateSOfTesting { get; set; }

        [NotMapped]
        public IEnumerable<TestGroup> TestGroups { get; set; }
    }
}
