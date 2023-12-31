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

        public async Task CreateVeterinarian(Veterinarian veterinarian)
        {
            _context.Veterinarians.Add(veterinarian);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<Veterinarian>> GetVeterinarians()
        {
            return await _context.Veterinarians.ToListAsync();            
        }
    }
}
