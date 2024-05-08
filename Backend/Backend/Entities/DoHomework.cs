using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Entities
{
    public class DoHomework
    {
        public int Id { get; set; }

        public int? PracticeId { get; set; }

        public int? UserId { get; set; }

        public HomeworkStatus HomeworkStatus { get; set; }

        public bool IsFinished { get; set; }

        [StringLength(500)]
        public string ActualOutput { get; set; }

        public DateTime? DoneTime { get; set; }

        public int? RegisterStudyId { get; set; }

        public Practice Practice { get; set; }

        public User User { get; set; }

        public RegisterStudy RegisterStudy { get; set; }
    }

    public enum HomeworkStatus
    {
        NotStarted,
        InProgress,
        Incorrect,
        Correct
    }
}
