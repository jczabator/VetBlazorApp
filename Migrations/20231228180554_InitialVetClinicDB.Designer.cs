﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VetBlazorApp.DataLayer;

#nullable disable

namespace VetBlazorApp.Migrations
{
    [DbContext(typeof(VetClinicDbContext))]
    [Migration("20231228180554_InitialVetClinicDB")]
    partial class InitialVetClinicDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VetBlazorApp.DataLayer.AnimalPassport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AnimalPassports");
                });

            modelBuilder.Entity("VetBlazorApp.DataLayer.Vaccination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnimalPassportId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("VaccineId")
                        .HasColumnType("int");

                    b.Property<int>("VeterinarianId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnimalPassportId");

                    b.HasIndex("VaccineId");

                    b.HasIndex("VeterinarianId");

                    b.ToTable("Vaccinations");
                });

            modelBuilder.Entity("VetBlazorApp.DataLayer.VaccineRegistry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VaccineName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VaccineRegistries");
                });

            modelBuilder.Entity("VetBlazorApp.DataLayer.Veterinarian", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LastName")
                        .HasColumnType("int");

                    b.Property<string>("SocialNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Veterinarians");
                });

            modelBuilder.Entity("VetBlazorApp.DataLayer.Vaccination", b =>
                {
                    b.HasOne("VetBlazorApp.DataLayer.AnimalPassport", "AnimalPassport")
                        .WithMany("Vaccinations")
                        .HasForeignKey("AnimalPassportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VetBlazorApp.DataLayer.VaccineRegistry", "Vaccine")
                        .WithMany("Vaccinations")
                        .HasForeignKey("VaccineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VetBlazorApp.DataLayer.Veterinarian", "Veterinarian")
                        .WithMany("Vaccinations")
                        .HasForeignKey("VeterinarianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AnimalPassport");

                    b.Navigation("Vaccine");

                    b.Navigation("Veterinarian");
                });

            modelBuilder.Entity("VetBlazorApp.DataLayer.AnimalPassport", b =>
                {
                    b.Navigation("Vaccinations");
                });

            modelBuilder.Entity("VetBlazorApp.DataLayer.VaccineRegistry", b =>
                {
                    b.Navigation("Vaccinations");
                });

            modelBuilder.Entity("VetBlazorApp.DataLayer.Veterinarian", b =>
                {
                    b.Navigation("Vaccinations");
                });
#pragma warning restore 612, 618
        }
    }
}