using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Entities
{
    public class Notification
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        [StringLength(255)]
        public string Image { get; set; }

        [Required]
        [StringLength(1000)]
        public string Content { get; set; }

        [StringLength(255)]
        public string Link { get; set; }

        public bool IsSeen { get; set; }

        public DateTime CreateTime { get; set; }

        public User User { get; set; }
    }
}
