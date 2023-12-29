using VetBlazorApp.DataLayer;

namespace VetBlazorApp.UseCases.GetVaccinations
{
    public interface IGetVaccinations
    {
        Task<IEnumerable<Vaccination>> GetVaccinations();
    }
}
