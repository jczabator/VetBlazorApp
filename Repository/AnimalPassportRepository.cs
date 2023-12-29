using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using VetBlazorApp.DataLayer;

namespace VetBlazorApp.Repository
{
    public class AnimalPassportRepository : IAnimalPassportRepository
    {
        private readonly VetClinicDbContext _context;

        public AnimalPassportRepository(VetClinicDbContext context)
        {
            _context = context;
        }

        public async Task CreateAnimal(AnimalPassport animalPassport)
        {
            await _context.AnimalPassports.AddAsync(animalPassport);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<AnimalPassport>> GetAnimalPassports()
        {
            return await _context.AnimalPassports.ToListAsync();
        }
    }
}
