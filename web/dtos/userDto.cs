using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using web.data.models;

namespace web.dtos
{
    public class userDto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Name must be between 5 to 50")]
        public string? Name { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        [Range(18, 50, ErrorMessage = "Age must be between 18 to 50")]
        public int? age { get; set; }
        List<pieceOfArtDto>? PieceOfArt { get; set; }
        public int? LoyaltyIdDto { get; set; }
        [ForeignKey("LoyaltyIdDto")]
        public loyaltyCardDto? Card { get; set; }
    }
}
