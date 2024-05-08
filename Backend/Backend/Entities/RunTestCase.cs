using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Entities
{
    public class RunTestCase
    {
        public int Id { get; set; }

        public int? DoHomeworkId { get; set; }

        public int? TestCaseId { get; set; }

        [StringLength(500)]
        public string Result { get; set; }

        public double RunTime { get; set; }

        public DoHomework DoHomework { get; set; }

        public TestCase TestCase { get; set; }
    }
}
