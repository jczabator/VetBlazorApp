using VetBlazorApp.DataLayer;
using VetBlazorApp.Repository;

namespace VetBlazorApp.UseCases.GetAnimalPassports
{
    public class GetAnimalPassportsUseCase : IGetAnimalPassports
    {
        private IAnimalPassportRepository _repository;

        public GetAnimalPassportsUseCase(IAnimalPassportRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<AnimalPassport>> GetAnimalPassports()
        {
            return await _repository.GetAnimalPassports();
        }
    }
}
