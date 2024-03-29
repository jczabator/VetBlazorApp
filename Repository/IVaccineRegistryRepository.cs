﻿using VetBlazorApp.DataLayer;

namespace VetBlazorApp.Repository
{
    public interface IVaccineRegistryRepository
    {
        Task<IEnumerable<VaccineRegistry>> GetVaccines();
        Task CreateVaccineRegistryEntry(VaccineRegistry vaccineRegistryEntry);
    }
}
