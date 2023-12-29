using System.ComponentModel.DataAnnotations;

namespace VetBlazorApp.Components.Models
{
    public class RegisterVaccinationForm
    {
        [Required]
        public int AnimalPassportId { get; set; }

        [Required]
        public int VaccineRegistryId { get; set; }

        [Required]
        public int VeterinarianId { get; set; }

        [Required]
        public DateTime? Date { get; set; }
    }
}
