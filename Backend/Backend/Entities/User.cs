using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Username { get; set; }

        [Required]
        public DateTime CreateTime { get; set; }

        [StringLength(255)]
        public string Avatar { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(255)]
        public string Email { get; set; }

        public DateTime? UpdateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string Password { get; set; }

        [StringLength(255)]
        public string FullName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public bool IsActive { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        public int DistrictId { get; set; }

        public int ProvinceId { get; set; }

        public int WardId { get; set; }

        public UserStatus UserStatus { get; set; }

        public bool IsLocked { get; set; }
        public Ward Ward { get; set; }

        public List<Permission> Permissions { get; set; }

        public List<ConfirmEmail> ConfirmEmails { get; set; }

        public List<RefreshToken> RefreshTokens { get; set; }
    }

    public enum UserStatus
    {
        Active,
        Inactive,
        Suspended
    }
}
