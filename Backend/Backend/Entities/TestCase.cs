using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Entities
{
    public class TestCase
    {
        public int Id { get; set; }

        public string Input { get; set; }

        public string Output { get; set; }

        public int? ProgramingLanguageId { get; set; }

        public int? PracticeId { get; set; }

        public ProgramingLanguage ProgramingLanguage { get; set; }

        public Practice Practice { get; set; }
    }
}
