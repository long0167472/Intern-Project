using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Entities
{
    public class LearningProgress
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int RegisterStudyId { get; set; }

        public int CurrentSubjectId { get; set; }

        public User User { get; set; }

        public RegisterStudy RegisterStudy { get; set; }

        public Subject CurrentSubject { get; set; }
    }
}
