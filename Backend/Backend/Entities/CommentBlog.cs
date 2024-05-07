using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Entities
{
    public class CommentBlog
    {
        public int Id { get; set; }

        public int BlogId { get; set; }

        public int UserId { get; set; }

        [Required]
        [StringLength(1000)]
        public string Content { get; set; }

        public bool Edited { get; set; }

        public Blog Blog { get; set; }

        public User User { get; set; }
    }
}
