using System.ComponentModel.DataAnnotations;

namespace VinylManager.Models
{
    public class Vinyl
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Year")]
        public int Year { get; set; }

        [Display(Name = "Condition")]
        public string? Condition { get; set; }

        [Display(Name = "Notes")]
        public string? Notes { get; set; }

        [Display(Name = "Artist")]
        public int ArtistId { get; set; }
        public Artist? Artist { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}