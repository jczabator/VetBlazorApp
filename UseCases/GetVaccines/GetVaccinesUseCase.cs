using VetBlazorApp.DataLayer;
using VetBlazorApp.Repository;

namespace VetBlazorApp.UseCases.GetVaccines
{
    public class GetVaccinesUseCase : IGetVaccines
    {
        private readonly IVaccineRegistryRepository _repository;

        public GetVaccinesUseCase(IVaccineRegistryRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<VaccineRegistry>> GetVaccines()
        {
            return await _repository.GetVaccines();
        }
    }
}
