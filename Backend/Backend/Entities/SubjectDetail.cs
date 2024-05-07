using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Entities
{
    public class SubjectDetail
    {
        public int Id { get; set; }

        public int SubjectId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsFinished { get; set; }

        [StringLength(500)]
        public string LinkVideo { get; set; }

        public bool IsActive { get; set; }

        public Subject Subject { get; set; }
    }
}
