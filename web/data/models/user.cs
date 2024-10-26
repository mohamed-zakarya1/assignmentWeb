using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web.data.models
{
    public class user
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
        List<pieceOfArt>? PieceOfArt { get; set; }
        public int? LoyaltyId { get; set; }
        [ForeignKey("LoyaltyId")]
        public loyaltyCard? Card { get; set; }
    }
}
