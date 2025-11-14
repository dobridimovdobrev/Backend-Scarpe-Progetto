using System.ComponentModel.DataAnnotations;

namespace Scarpe___Co_Progetto.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Main image is required")]
        public string MainImage { get; set; } = string.Empty;

        [Required(ErrorMessage = "Second image is required")]
        public string Image2 { get; set; } = string.Empty;

        [Required(ErrorMessage = "Third image is required")]
        public string Image3 { get; set; } = string.Empty;

    }
}
