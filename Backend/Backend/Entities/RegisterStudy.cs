using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Entities
{
    public class RegisterStudy
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int CourseId { get; set; }

        public int CurrentSubjectId { get; set; }

        public bool IsFinished { get; set; }

        public DateTime RegisterTime { get; set; }

        public int PercentComplete { get; set; }

        public DateTime? DoneTime { get; set; }

        public bool IsActive { get; set; }

        public User User { get; set; }

        public Course Course { get; set; }

        public Subject CurrentSubject { get; set; }

        public List<DoHomework> DoHomeworks { get; set; }
    }
}
