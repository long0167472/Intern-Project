using System.ComponentModel.DataAnnotations;

namespace Backend.Entities
{
    public class Province
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public List<District> Districts { get; set; }
    }
}
