using System.ComponentModel.DataAnnotations;

namespace Backend.Entities
{
    public class Role
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string RoleCode { get; set; }

        [Required]
        [StringLength(255)]
        public string RoleName { get; set; }

        public List<Permission> Permissions { get; set; }
    }

}
