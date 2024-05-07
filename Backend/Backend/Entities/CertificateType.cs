using System.ComponentModel.DataAnnotations;

namespace Backend.Entities
{
    public class CertificateType
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public List<Certificate> Certificates { get; set; }
    }

}
