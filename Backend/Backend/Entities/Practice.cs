using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Entities
{
    public class Practice
    {
        public int Id { get; set; }

        public int SubjectDetailId { get; set; }

        public PracticeLevel Level { get; set; }

        [Required]
        [StringLength(50)]
        public string PracticeCode { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Topic { get; set; }

        [StringLength(500)]
        public string ExpectOutput { get; set; }

        public int LanguageProgrammingId { get; set; }

        public bool IsRequired { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime? UpdateTime { get; set; }

        public bool IsDeleted { get; set; }

        public double? MediumScore { get; set; }

        public SubjectDetail SubjectDetail { get; set; }

        public ProgramingLanguage LanguageProgramming { get; set; }
    }

    public enum PracticeLevel
    {
        Beginner,
        Intermediate,
        Advanced
    }
}
