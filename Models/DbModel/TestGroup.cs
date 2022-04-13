using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnIT_ComAp.Models.DbModel
{
    public class TestGroup
    {
        public long HeadId { get; set; }
        public long Id { get; set; }
        public bool Success { get; set; }

        [NotMapped]
        public IEnumerable<Test> Tests { get; set; }
    }
}
