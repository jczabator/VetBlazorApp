using VetBlazorApp.DataLayer;

namespace VetBlazorApp.UseCases.GetAnimalPassports
{
    public interface IGetAnimalPassports
    {
        Task<IEnumerable<AnimalPassport>> GetAnimalPassports();
    }
}
