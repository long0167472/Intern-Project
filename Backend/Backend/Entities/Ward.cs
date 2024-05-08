using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Entities
{
    public class Ward
    {
        public int Id { get; set; }

        public int? DistrictId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public District District { get; set; }
    }
}
