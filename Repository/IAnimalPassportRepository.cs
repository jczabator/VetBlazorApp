using VetBlazorApp.DataLayer;

namespace VetBlazorApp.Repository
{
    public interface IAnimalPassportRepository
    {
        Task<IEnumerable<AnimalPassport>> GetAnimalPassports();

        Task CreateAnimal(AnimalPassport animalPassport);
    }
}
