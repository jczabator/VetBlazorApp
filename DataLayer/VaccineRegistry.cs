namespace VetBlazorApp.DataLayer
{
    public class VaccineRegistry
    {
        public int Id { get; set; }
        public string VaccineName { get; set; }
        public string SerialNumber { get; set; }
        public DateTime ExpiryDate { get; set; }

        public IList<Vaccination> Vaccinations { get; set; }
    }
}
