using VetBlazorApp.DataLayer;
using VetBlazorApp.Repository;

namespace VetBlazorApp.UseCases.CreateAnimal
{
    public class CreateAnimalUseCase : ICreateAnimal
    {
        private readonly IAnimalPassportRepository _animalPassportRepository;

        public CreateAnimalUseCase(IAnimalPassportRepository animalPassportRepository)
        {
            _animalPassportRepository = animalPassportRepository;
        }

        public async Task CreateAnimal(AnimalPassport passport)
        {
            await _animalPassportRepository.CreateAnimal(passport);
        }
    }
}
