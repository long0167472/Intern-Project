using System.ComponentModel.DataAnnotations;

namespace Backend.Entities
{
    public class Subject
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Symbol { get; set; }

        public bool IsActive { get; set; }
    }
}
