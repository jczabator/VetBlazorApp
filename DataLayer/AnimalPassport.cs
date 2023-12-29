namespace VetBlazorApp.DataLayer
{
    public class AnimalPassport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public string Gender { get; set; }

        public IList<Vaccination> Vaccinations { get; set; }
    }
}
