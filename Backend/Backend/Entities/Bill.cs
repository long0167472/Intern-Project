using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Entities
{
    public class Bill
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int CourseId { get; set; }

        public decimal Price { get; set; }

        [StringLength(50)]
        public string TradingCode { get; set; }

        public DateTime CreateTime { get; set; }

        public int BillStatusId { get; set; }

        public User User { get; set; }

        public Course Course { get; set; }

        public BillStatus BillStatus { get; set; }
    }
}
