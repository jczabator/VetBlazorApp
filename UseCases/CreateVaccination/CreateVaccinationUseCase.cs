using VetBlazorApp.DataLayer;
using VetBlazorApp.Repository;

namespace VetBlazorApp.UseCases.CreateVaccination
{
    public class CreateVaccinationUseCase : ICreateVaccination
    {
        private readonly IVaccinationRepository _repository;

        public CreateVaccinationUseCase(IVaccinationRepository repository)
        {
            _repository = repository;
        }

        public async Task CreateVaccination(Vaccination vaccination)
        {
            await _repository.CreateVaccination(vaccination);
        }
    }
}
