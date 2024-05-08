using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Entities
{
    public class MakeQuestion
    {
        public int Id { get; set; }

        public int? UserId { get; set; }

        public int? SubjectDetailId { get; set; }

        [Required]
        [StringLength(1000)]
        public string Question { get; set; }

        public int NumberOfAnswers { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime? UpdateTime { get; set; }

        public User User { get; set; }

        public SubjectDetail SubjectDetail { get; set; }
    }
}
