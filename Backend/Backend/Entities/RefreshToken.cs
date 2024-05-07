using System.ComponentModel.DataAnnotations;

namespace Backend.Entities
{
    public class RefreshToken
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Token { get; set; }

        public DateTime ExpiryTime { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }

}
