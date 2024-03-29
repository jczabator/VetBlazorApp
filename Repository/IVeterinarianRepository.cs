﻿using VetBlazorApp.DataLayer;

namespace VetBlazorApp.Repository
{
    public interface IVeterinarianRepository
    {
        Task<IEnumerable<Veterinarian>> GetVeterinarians();
        Task CreateVeterinarian(Veterinarian veterinarian);
    }
}
