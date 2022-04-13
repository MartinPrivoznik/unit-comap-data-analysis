using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnIT_ComAp.Models.DbModel
{
    public class Test
    {
        public int HeadId { get; set; }
        public int GroupId { get; set; }
        public string Id { get; set; }
        public string Title { get; set; }

        [NotMapped]
        public IEnumerable<TestOperation> TestOperations { get; set; }
    }
}
