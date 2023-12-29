using VetBlazorApp.DataLayer;

namespace VetBlazorApp.UseCases.GetVaccines
{
    public interface IGetVaccines
    {
        Task<IEnumerable<VaccineRegistry>> GetVaccines();
    }
}
