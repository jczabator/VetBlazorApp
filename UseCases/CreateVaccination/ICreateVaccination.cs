using VetBlazorApp.DataLayer;

namespace VetBlazorApp.UseCases.CreateVaccination
{
    public interface ICreateVaccination
    {
        Task CreateVaccination(Vaccination vaccination);
    }
}
