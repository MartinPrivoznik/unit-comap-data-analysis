using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnIT_ComAp.Models.DbModel
{
    public class TestGroup
    {
        public string HeadId { get; set; }
        public long Id { get; set; }
        public bool Success { get; set; }
        public string Title { get; set; }

        [NotMapped]
        public IEnumerable<Test> Tests { get; set; }
    }
}
