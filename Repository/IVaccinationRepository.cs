using VetBlazorApp.DataLayer;

namespace VetBlazorApp.Repository
{
    public interface IVaccinationRepository
    {
        Task<IEnumerable<Vaccination>> GetVaccinations();

        Task CreateVaccination(Vaccination vaccination);
    }
}
