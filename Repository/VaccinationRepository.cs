using Microsoft.EntityFrameworkCore;
using VetBlazorApp.DataLayer;

namespace VetBlazorApp.Repository
{
    public class VaccinationRepository : IVaccinationRepository
    {
        private readonly VetClinicDbContext _context;

        public VaccinationRepository(VetClinicDbContext context)
        {
            _context = context;
        }

        public async Task CreateVaccination(Vaccination vaccination)
        {
            await _context.AddAsync(vaccination);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Vaccination>> GetVaccinations()
        {
            return await _context.Vaccinations
                .AsNoTracking()
                .Include(v => v.Veterinarian)
                .Include(v => v.VaccineRegistry)
                .Include(v => v.AnimalPassport)
                .ToListAsync();
        }
    }
}
