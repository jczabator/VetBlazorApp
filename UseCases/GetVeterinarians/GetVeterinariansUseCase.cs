using VetBlazorApp.DataLayer;
using VetBlazorApp.Repository;

namespace VetBlazorApp.UseCases.GetVeterinarians
{
    public class GetVeterinariansUseCase : IGetVeterinarians
    {
        private readonly IVeterinarianRepository _repository;

        public GetVeterinariansUseCase(IVeterinarianRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Veterinarian>> GetVeterinarians()
        {
            return await _repository.GetVeterinarians();
        }
    }
}
