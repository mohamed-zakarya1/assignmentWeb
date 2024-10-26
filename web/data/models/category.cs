using System.ComponentModel.DataAnnotations;

namespace web.data.models
{
    public class category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Name must be between 5 to 50")]
        public string? Name { get; set; }
        [Required]
        [StringLength(300, MinimumLength = 5, ErrorMessage = "Desc.. must be between 5 to 50")]
        public string? Description { get; set; }
        List<pieceOfArt>? pieceOfArt { get; set; }
    }
}
