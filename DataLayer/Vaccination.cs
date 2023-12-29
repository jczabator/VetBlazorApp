namespace VetBlazorApp.DataLayer
{
    public class Vaccination
    {
        public int Id { get; set; }
        public int AnimalPassportId { get; set; }
        public int VaccineRegistryId { get; set; }
        public int VeterinarianId { get; set; }
        public DateTime Date { get; set; }
        public AnimalPassport AnimalPassport { get; set; }
        public VaccineRegistry VaccineRegistry { get; set; }
        public Veterinarian Veterinarian { get; set; }
    }
}
