using System.ComponentModel.DataAnnotations;

namespace VetBlazorApp.Components.Models
{
    public class RegisterVaccineForm
    {
        [Required]
        public string VaccineName { get; set; }
        [Required]
        public string SerialNumber { get; set; }
        [Required]
        public DateTime? ExpiryDate { get; set; }
    }
}
