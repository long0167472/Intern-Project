using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Entities
{
    public class District
    {
        public int Id { get; set; }

        public int ProvinceId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Province Province { get; set; }

        public List<Ward> Wards { get; set; }
    }
}
