using System.ComponentModel.DataAnnotations;

namespace Backend.Entities
{
    public class ConfirmEmail
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string ConfirmCode { get; set; }

        public DateTime ExpiryTime { get; set; }

        public int UserId { get; set; }

        public bool IsConfirm { get; set; }

        public User User { get; set; }
    }

}
