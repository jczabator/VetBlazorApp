using Microsoft.EntityFrameworkCore;

namespace VetBlazorApp.DataLayer
{
    public class VetClinicDbContext : DbContext
    {
        public DbSet<AnimalPassport> AnimalPassports { get; set; }
        public DbSet<Vaccination> Vaccinations { get; set; }
        public DbSet<VaccineRegistry> VaccineRegistries { get; set; }
        public DbSet<Veterinarian> Veterinarians { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=VetClinic;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Veterinarian>().HasData(new Veterinarian { Id = 1, FirstName = "Luke", LastName = "Vader", SocialNumber = "12345" });
            modelBuilder.Entity<AnimalPassport>().HasData(new AnimalPassport { Id = 1, Name = "A Dog", Age = 11, Breed = "SomeBreed", Gender = "Male" });
            modelBuilder.Entity<VaccineRegistry>().HasData(new VaccineRegistry { Id = 1, VaccineName = "Vaccine1", SerialNumber = "12345", ExpiryDate = DateTime.UtcNow.AddYears(1) });
            modelBuilder.Entity<Vaccination>().HasData(new Vaccination { Id = 1, AnimalPassportId = 1, VaccineRegistryId = 1, VeterinarianId = 1, Date = DateTime.UtcNow });
        }
    }
}
