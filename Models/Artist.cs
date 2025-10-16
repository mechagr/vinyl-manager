using System.ComponentModel.DataAnnotations;

namespace VinylManager.Models
{
    public class Artist
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Artist Name")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Biography")]
        public string? Bio { get; set; }

        public List<Vinyl> Vinyls { get; set; } = new();
    }
}
