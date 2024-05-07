using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Entities
{
    public class Answers
    {
        public int Id { get; set; }

        public int QuestionId { get; set; }

        public int UserId { get; set; }

        [Required]
        [StringLength(1000)]
        public string Answer { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime? UpdateTime { get; set; }

        public MakeQuestion Question { get; set; }

        public User User { get; set; }
    }
}
