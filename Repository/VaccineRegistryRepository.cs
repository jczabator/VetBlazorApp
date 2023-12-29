﻿using Microsoft.EntityFrameworkCore;
using VetBlazorApp.DataLayer;

namespace VetBlazorApp.Repository
{
    public class VaccineRegistryRepository : IVaccineRegistryRepository
    {
        private readonly VetClinicDbContext _context;

        public VaccineRegistryRepository(VetClinicDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<VaccineRegistry>> GetVaccines()
        {
            return await _context.VaccineRegistries.ToListAsync();
        }
    }
}
