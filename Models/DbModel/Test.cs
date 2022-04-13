using System.ComponentModel.DataAnnotations;

namespace UnIT_ComAp.Models.DbModel
{
    public class Test
    {
        [Key]
        public int HeadId { get; set; }
        [Key]
        public int GroupId { get; set; }
        [Key]
        public string Id { get; set; }

        public string Title { get; set; }
    }
}
