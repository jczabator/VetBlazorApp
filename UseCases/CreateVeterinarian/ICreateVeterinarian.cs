using VetBlazorApp.DataLayer;

namespace VetBlazorApp.UseCases.CreateVeterinarian
{
    public interface ICreateVeterinarian
    {
        Task CreateVeterinarian(Veterinarian veterinarian);
    }
}
