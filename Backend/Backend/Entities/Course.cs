using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Entities
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Introduce { get; set; }

        [StringLength(255)]
        public string ImageCourse { get; set; }

        public int CreatorId { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        public decimal Price { get; set; }

        public int TotalCourseDuration { get; set; }

        public int NumberOfStudent { get; set; }

        public int NumberOfPurchases { get; set; }

        public User Creator { get; set; }

        public List<CourseSubject> CourseSubjects { get; set; }

        public List<RegisterStudy> RegisterStudies { get; set; }
    }
}
