using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnIT_ComAp.Models.DbModel
{
    public class TestGroup
    {
        [Key]
        public int HeadId { get; set; }
        [Key]
        public int Id { get; set; }
        public bool Success { get; set; }
    }
}
