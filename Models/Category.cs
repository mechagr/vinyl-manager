using System.ComponentModel.DataAnnotations;

namespace VinylManager.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Category Name")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Description")]
        public string? Description { get; set; }

        public List<Vinyl> Vinyls { get; set; } = new List<Vinyl>();
    }
}