using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using web.data.models;

namespace web.dtos
{
    public class pieceOfArtDto
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
        public int? userIdDto { get; set; }
        [ForeignKey("userIdDto")]
        public userDto? User { get; set; }
        public int? CategoryIdDto { get; set; }
        [ForeignKey("CategoryIdDto")]
        public categoryDto? Category { get; set; }
    }
}
