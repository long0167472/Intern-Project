using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Entities
{
    public class CourseSubject
    {
        public int Id { get; set; }

        public int? CourseId { get; set; }

        public int? SubjectId { get; set; }

        public Course Course { get; set; }

        public Subject Subject { get; set; }
    }
}
