using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web.data.models
{
    public class pieceOfArt
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Title must be between 5 to 50")]
        public string? Title { get; set; }
        [Required]
        public string? Price { get; set; }
        [Required]
        public DateTime? Publication_date { get; set; }
        public int? userId { get; set; }
        [ForeignKey("userId")]
        public user? User { get; set; }
        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public category? Category { get; set; }
    }
}
