using System.ComponentModel.DataAnnotations;

namespace Backend.Entities
{
    public class Certificate
    {
        public int Id { get; set; }

        public int? CertificateTypeId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(255)]
        public string Image { get; set; }

        public CertificateType CertificateType { get; set; }

        public List<User> Users { get; set; }
    }

}
