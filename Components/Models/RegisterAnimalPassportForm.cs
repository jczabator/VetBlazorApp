using System.ComponentModel.DataAnnotations;

namespace VetBlazorApp.Components.Models
{
    public class RegisterAnimalPassportForm
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Breed { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}
