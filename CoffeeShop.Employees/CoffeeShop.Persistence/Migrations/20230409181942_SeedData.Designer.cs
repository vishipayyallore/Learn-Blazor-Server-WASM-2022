﻿// <auto-generated />
using System;
using CoffeeShop.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoffeeShop.Persistence.Migrations
{
    [DbContext(typeof(EmployeeManagerDbContext))]
    [Migration("20230409181942_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CoffeeShop.Data.Entities.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5af7e850-75d0-42cf-aeba-996811fe6012"),
                            Name = "Finance"
                        },
                        new
                        {
                            Id = new Guid("5af7e850-75d0-42cf-aeba-996811fe6013"),
                            Name = "Sales"
                        },
                        new
                        {
                            Id = new Guid("5af7e850-75d0-42cf-aeba-996811fe6014"),
                            Name = "Marketing"
                        },
                        new
                        {
                            Id = new Guid("5af7e850-75d0-42cf-aeba-996811fe6015"),
                            Name = "Human Resources"
                        },
                        new
                        {
                            Id = new Guid("5af7e850-75d0-42cf-aeba-996811fe6016"),
                            Name = "IT"
                        });
                });

            modelBuilder.Entity("CoffeeShop.Data.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DepartmentId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeveloper")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1b0e17a7-c0bf-4825-95c5-d338dda5f206"),
                            DepartmentId = new Guid("5af7e850-75d0-42cf-aeba-996811fe6013"),
                            FirstName = "Anna",
                            IsDeveloper = false,
                            LastName = "Rockstar"
                        },
                        new
                        {
                            Id = new Guid("cab67856-d3c5-4c03-bc26-f19683ff6666"),
                            DepartmentId = new Guid("5af7e850-75d0-42cf-aeba-996811fe6016"),
                            FirstName = "Julia",
                            IsDeveloper = true,
                            LastName = "Developer"
                        },
                        new
                        {
                            Id = new Guid("4e6ee4b6-2100-4e6e-a8fc-38c7b76d61be"),
                            DepartmentId = new Guid("5af7e850-75d0-42cf-aeba-996811fe6016"),
                            FirstName = "Thomas",
                            IsDeveloper = true,
                            LastName = "Huber"
                        },
                        new
                        {
                            Id = new Guid("b79f809b-19a5-4f6a-a776-8141d04d4c57"),
                            DepartmentId = new Guid("5af7e850-75d0-42cf-aeba-996811fe6012"),
                            FirstName = "Sara",
                            IsDeveloper = false,
                            LastName = "Metroid"
                        },
                        new
                        {
                            Id = new Guid("bb6309e8-e2e8-491e-9985-f70e4f4a87f7"),
                            DepartmentId = new Guid("5af7e850-75d0-42cf-aeba-996811fe6015"),
                            FirstName = "Ben",
                            IsDeveloper = false,
                            LastName = "Rockstar"
                        },
                        new
                        {
                            Id = new Guid("863e90b4-c76c-4cfc-8ff9-f502f3e9500d"),
                            DepartmentId = new Guid("5af7e850-75d0-42cf-aeba-996811fe6014"),
                            FirstName = "Alex",
                            IsDeveloper = true,
                            LastName = "Rider"
                        },
                        new
                        {
                            Id = new Guid("95501e22-6b9a-42c4-a25b-50c9491d678e"),
                            DepartmentId = new Guid("5af7e850-75d0-42cf-aeba-996811fe6016"),
                            FirstName = "Sophie",
                            IsDeveloper = false,
                            LastName = "Ramos"
                        },
                        new
                        {
                            Id = new Guid("48570627-f4e7-45ee-9bf0-f37744eaa408"),
                            DepartmentId = new Guid("5af7e850-75d0-42cf-aeba-996811fe6013"),
                            FirstName = "Julien",
                            IsDeveloper = false,
                            LastName = "Russell"
                        },
                        new
                        {
                            Id = new Guid("8b573f2d-7d44-4ff6-903d-12a7ad6b2421"),
                            DepartmentId = new Guid("5af7e850-75d0-42cf-aeba-996811fe6015"),
                            FirstName = "Yvonne",
                            IsDeveloper = false,
                            LastName = "Snider"
                        },
                        new
                        {
                            Id = new Guid("6e092e54-7b81-40b4-a28b-3150c308965a"),
                            DepartmentId = new Guid("5af7e850-75d0-42cf-aeba-996811fe6012"),
                            FirstName = "Jasmin",
                            IsDeveloper = true,
                            LastName = "Curtis"
                        });
                });

            modelBuilder.Entity("CoffeeShop.Data.Entities.Employee", b =>
                {
                    b.HasOne("CoffeeShop.Data.Entities.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("CoffeeShop.Data.Entities.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
