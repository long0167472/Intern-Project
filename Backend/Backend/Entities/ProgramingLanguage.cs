using System.ComponentModel.DataAnnotations;

namespace Backend.Entities
{
    public class ProgramingLanguage { 
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string LanguageName { get; set; }
    }
}
