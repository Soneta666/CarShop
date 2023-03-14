﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(CarDbContext))]
    [Migration("20230310183102_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Core.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EngineId")
                        .HasColumnType("int");

                    b.Property<int>("MakeId")
                        .HasColumnType("int");

                    b.Property<double>("MaxSpeed")
                        .HasColumnType("float");

                    b.Property<double>("Mileage")
                        .HasColumnType("float");

                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.Property<double>("SecondSpeed")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("EngineId");

                    b.HasIndex("MakeId");

                    b.HasIndex("ModelId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Core.Entities.Engine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Cylinders")
                        .HasColumnType("int");

                    b.Property<int>("FuelConsumption")
                        .HasColumnType("int");

                    b.Property<double>("Horsepower")
                        .HasColumnType("float");

                    b.Property<int>("TypeEngineId")
                        .HasColumnType("int");

                    b.Property<double>("Volume")
                        .HasColumnType("float");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("TypeEngineId");

                    b.ToTable("Engines");
                });

            modelBuilder.Entity("Core.Entities.Make", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Makes");
                });

            modelBuilder.Entity("Core.Entities.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdYear")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdYear");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("Core.Entities.TypeEngine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TypeEngines");
                });

            modelBuilder.Entity("Core.Entities.Year", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Years");
                });

            modelBuilder.Entity("Core.Entities.Car", b =>
                {
                    b.HasOne("Core.Entities.Engine", "Engine")
                        .WithMany("Cars")
                        .HasForeignKey("EngineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Make", "Make")
                        .WithMany("Cars")
                        .HasForeignKey("MakeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Model", "Model")
                        .WithMany("Cars")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Engine");

                    b.Navigation("Make");

                    b.Navigation("Model");
                });

            modelBuilder.Entity("Core.Entities.Engine", b =>
                {
                    b.HasOne("Core.Entities.TypeEngine", "TypeEngine")
                        .WithMany("Engines")
                        .HasForeignKey("TypeEngineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TypeEngine");
                });

            modelBuilder.Entity("Core.Entities.Model", b =>
                {
                    b.HasOne("Core.Entities.Year", "Year")
                        .WithMany("Models")
                        .HasForeignKey("IdYear")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Year");
                });

            modelBuilder.Entity("Core.Entities.Engine", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("Core.Entities.Make", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("Core.Entities.Model", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("Core.Entities.TypeEngine", b =>
                {
                    b.Navigation("Engines");
                });

            modelBuilder.Entity("Core.Entities.Year", b =>
                {
                    b.Navigation("Models");
                });
#pragma warning restore 612, 618
        }
    }
}
