namespace VetBlazorApp.DataLayer
{
    public class Veterinarian
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocialNumber { get; set; }

        public IList<Vaccination> Vaccinations { get; set; }
    }
}
