using System.ComponentModel.DataAnnotations;

namespace Backend.Entities
{
    public class BillStatus
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}
