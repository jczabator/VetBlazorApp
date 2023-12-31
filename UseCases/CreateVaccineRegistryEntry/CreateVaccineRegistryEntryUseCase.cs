using VetBlazorApp.DataLayer;
using VetBlazorApp.Repository;

namespace VetBlazorApp.UseCases.CreateVaccineRegistryEntry
{
    public class CreateVaccineRegistryEntryUseCase : ICreateVaccineRegistryEntry
    {
        private readonly IVaccineRegistryRepository _repository;

        public CreateVaccineRegistryEntryUseCase(IVaccineRegistryRepository repository)
        {
            _repository = repository;
        }

        public async Task CreateVaccineRegistryEntry(VaccineRegistry vaccineRegistry)
        {
            await _repository.CreateVaccineRegistryEntry(vaccineRegistry);
        }
    }
}
