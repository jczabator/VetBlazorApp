using VetBlazorApp.DataLayer;
using VetBlazorApp.Repository;

namespace VetBlazorApp.UseCases.CreateVeterinarian
{
    public class CreateVeterinarianUseCase : ICreateVeterinarian
    {
        private readonly IVeterinarianRepository _repository;

        public CreateVeterinarianUseCase(IVeterinarianRepository repository)
        {
            _repository = repository;
        }

        public async Task CreateVeterinarian(Veterinarian veterinarian)
        {
            await _repository.CreateVeterinarian(veterinarian);
        }
    }
}
