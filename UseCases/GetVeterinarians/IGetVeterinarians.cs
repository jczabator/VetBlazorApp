using VetBlazorApp.DataLayer;

namespace VetBlazorApp.UseCases.GetVeterinarians
{
    public interface IGetVeterinarians
    {
        Task<IEnumerable<Veterinarian>> GetVeterinarians();
    }
}
