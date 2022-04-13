using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnIT_ComAp.Models.DbModel
{
    public class Test
    {
        public long HeadId { get; set; }
        public long GroupId { get; set; }
        public long Id { get; set; }
        public string Title { get; set; }

        [NotMapped]
        public IEnumerable<TestOperation> TestOperations { get; set; }
    }
}
