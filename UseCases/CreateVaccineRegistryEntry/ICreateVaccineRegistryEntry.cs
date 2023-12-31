using VetBlazorApp.DataLayer;

namespace VetBlazorApp.UseCases.CreateVaccineRegistryEntry
{
    public interface ICreateVaccineRegistryEntry
    {
        Task CreateVaccineRegistryEntry(VaccineRegistry vaccineRegistry);
    }
}
