using Microsoft.EntityFrameworkCore;
using VetBlazorApp.DataLayer;

namespace VetBlazorApp.Repository
{
    public class VeterinarianRepository : IVeterinarianRepository
    {
        private readonly VetClinicDbContext _context;

        public VeterinarianRepository(VetClinicDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Veterinarian>> GetVeterinarians()
        {
            return await _context.Veterinarians.ToListAsync();
            
        }
    }
}
