using VetBlazorApp.DataLayer;
using VetBlazorApp.Repository;

namespace VetBlazorApp.UseCases.GetVaccinations
{
    public class GetVaccinationsUseCase : IGetVaccinations
    {
        private readonly IVaccinationRepository _vaccinationRepository;

        public GetVaccinationsUseCase(IVaccinationRepository vaccinationRepository)
        {
            _vaccinationRepository = vaccinationRepository;
        }

        public async Task<IEnumerable<Vaccination>> GetVaccinations()
        {
            return await _vaccinationRepository.GetVaccinations();
        }
    }
}
