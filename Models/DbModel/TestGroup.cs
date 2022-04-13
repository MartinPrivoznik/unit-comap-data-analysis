using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnIT_ComAp.Models.DbModel
{
    public class TestGroup
    {
        public int HeadId { get; set; }
        public int Id { get; set; }
        public bool Success { get; set; }

        [NotMapped]
        public IEnumerable<TestGroup> Tests { get; set; }
    }
}
