using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Entities
{
    public class Blog
    {
        public int Id { get; set; }

        public int CreatorId { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        [StringLength(1000)]
        public string Content { get; set; }

        public int NumberOfLikes { get; set; }

        public int NumberOfComments { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime? UpdateTime { get; set; }

        public User Creator { get; set; }

        public List<CommentBlog> Comments { get; set; }

        public List<LikeBlog> Likes { get; set; }
    }
}
