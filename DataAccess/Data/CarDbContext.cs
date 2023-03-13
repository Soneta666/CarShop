using Core.Entities;
using Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Reflection.Emit;

namespace Infrastructure.Data
{
    public class CarDbContext : DbContext
    {

        public CarDbContext() : base() { }

        public CarDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.SeedYears();
            modelBuilder.SeedModels();
            modelBuilder.SeedMakes();
            modelBuilder.SeedEngines();
            modelBuilder.SeedCars();
            //

            //DbContextExtensions.SeedCars(modelBuilder);

            modelBuilder.ApplyConfiguration(new CarConfiguration());
            modelBuilder.ApplyConfiguration(new ModelConfigurations());

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CarShop;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            optionsBuilder.UseSqlServer(connStr);
        }

        /* ----------------- Data Collections -----------------*/
        public DbSet<Car> Cars { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Core.Entities.Model> Models { get; set; }
        public DbSet<Year> Years { get; set; }
    }

}