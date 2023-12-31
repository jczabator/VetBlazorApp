using VetBlazorApp.Components;
using MudBlazor.Services;
using VetBlazorApp.Repository;
using VetBlazorApp.UseCases.GetVaccinations;
using VetBlazorApp.DataLayer;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using VetBlazorApp.UseCases.GetAnimalPassports;
using VetBlazorApp.UseCases.GetVeterinarians;
using VetBlazorApp.UseCases.GetVaccines;
using VetBlazorApp.UseCases.CreateVaccination;
using VetBlazorApp.UseCases.CreateAnimal;
using VetBlazorApp.UseCases.CreateVeterinarian;
using VetBlazorApp.UseCases.CreateVaccineRegistryEntry;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<VetClinicDbContext>();

builder.Services.AddTransient<IVaccinationRepository, VaccinationRepository>();
builder.Services.AddTransient<IGetVaccinations, GetVaccinationsUseCase>();
builder.Services.AddTransient<IAnimalPassportRepository, AnimalPassportRepository>();
builder.Services.AddTransient<IGetAnimalPassports, GetAnimalPassportsUseCase>();
builder.Services.AddTransient<IVeterinarianRepository, VeterinarianRepository>();
builder.Services.AddTransient<IGetVeterinarians, GetVeterinariansUseCase>();
builder.Services.AddTransient<IVaccineRegistryRepository, VaccineRegistryRepository>();
builder.Services.AddTransient<IGetVaccines, GetVaccinesUseCase>();
builder.Services.AddTransient<ICreateVaccination, CreateVaccinationUseCase>();
builder.Services.AddTransient<ICreateAnimal, CreateAnimalUseCase>();
builder.Services.AddTransient<ICreateVeterinarian, CreateVeterinarianUseCase>();
builder.Services.AddTransient<ICreateVaccineRegistryEntry, CreateVaccineRegistryEntryUseCase>();

builder.Services.AddMudServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
