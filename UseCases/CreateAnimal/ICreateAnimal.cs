using VetBlazorApp.DataLayer;

namespace VetBlazorApp.UseCases.CreateAnimal
{
    public interface ICreateAnimal
    {
        Task CreateAnimal(AnimalPassport passport);
    }
}
