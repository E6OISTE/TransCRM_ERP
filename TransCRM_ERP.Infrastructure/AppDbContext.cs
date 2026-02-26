using Microsoft.EntityFrameworkCore;
using TransCRM_ERP.Entites.BaseData;
using TransCRM_ERP.Entites.SecondaryData;

namespace TransCRM_ERP.Infrastructure
{
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// DbSet<inheritdoc cref = "Required" />
        /// </ summary >
        public DbSet<Required> Requireds { get; set; }

        /// <summary>
        /// DbSet<inheritdoc cref="Waybill"/>
        /// </summary>
        public DbSet<Waybill> Waybills { get; set; }

        /// <summary>
        /// DbSet<inheritdoc cref="Autotransport"/>
        /// </summary>
        public DbSet<Autotransport> Autotransports { get; set; }

        /// <summary>
        /// DbSet<inheritdoc cref="Driver"/>
        /// </summary>
        public DbSet<Driver> Drivers { get; set; }

        /// <summary>
        /// DbSet<inheritdoc cref="DriverLicense"/>
        /// </summary>
        public DbSet<DriverLicense> DriverLicenses { get; set; }

        /// <summary>
        /// DbSet<inheritdoc cref="Passport"/>
        /// </summary>
        public DbSet<Passport> Passports { get; set; }

        /// <summary>
        /// DbSet<inheritdoc cref="DrivingRoute"/>
        /// </summary>
        public DbSet<DrivingRoute> DrivingRoutes { get; set; }

        /// <summary>
        /// DbSet<inheritdoc cref = "AddressPoint" />
        /// </ summary >
        public DbSet<AddressPoint> AddressPoints { get; set; }

        public AppDbContext() => Database.EnsureCreated();
        public AppDbContext(DbContextOptions options) : base(options) => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite($"Data Source=" +
                $"{Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "sqliteDbTrans.db")}");

            //optionsBuilder.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Required>();
            modelBuilder.Entity<Required>().HasQueryFilter(d => !d.IsDeleted);
            modelBuilder.Entity<Required>()         // many -> 1
                .HasMany(w => w.Waybills)
                .WithOne(r => r.Required)
                .HasForeignKey(fk => fk.RequiredID)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Required>()         // many -> 1
                .HasMany(d => d.DrivingRoutes)
                .WithOne(r => r.Required)
                .HasForeignKey(fk => fk.RequiredID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Autotransport>();
            modelBuilder.Entity<Autotransport>().HasQueryFilter(d => !d.IsDeleted);
            modelBuilder.Entity<Autotransport>()    // 1 -> 1
                .HasOne(a => a.Required)
                .WithOne(r => r.Autotransport)
                .HasForeignKey<Required>(fk => fk.AutotransportId)
                .IsRequired(false);

            modelBuilder.Entity<Driver>();
            //modelBuilder.Entity<Driver>().HasQueryFilter(d => !d.IsDeleted);
            modelBuilder.Entity<Driver>()           // 1 -> 1
                .HasOne(d => d.Required)
                .WithOne(r => r.Driver)
                .HasForeignKey<Required>(fk => fk.DriverId)
                .IsRequired(false);

            modelBuilder.Entity<Waybill>();

            modelBuilder.Entity<DriverLicense>();
            //modelBuilder.Entity<DriverLicense>().HasQueryFilter(d => !d.IsDeleted);
            //modelBuilder.Entity<DriverLicense>()    // 1 -> 1
            //    .HasOne(dl => dl.Driver)
            //    .WithOne(d => d.DriverLicense)
            //    .HasForeignKey<Driver>(fk => fk.DriverLicenseId)
            //    .IsRequired(true)
            //    .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Passport>();
            modelBuilder.Entity<Passport>().HasQueryFilter(d => !d.IsDeleted);
            //modelBuilder.Entity<Passport>()         // 1 -> 1
            //    .HasOne(p => p.Driver)
            //    .WithOne(d => d.Passport)
            //    .HasForeignKey<Driver>(fk => fk.PassportId)
            //    .IsRequired(true)
            //    .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DrivingRoute>();
            modelBuilder.Entity<DrivingRoute>().HasQueryFilter(d => !d.IsDeleted);
            modelBuilder.Entity<DrivingRoute>()     // 1 -> many
                .HasOne(al => al.AddressLoading)
                .WithMany(dr => dr.AddressLoading)
                .HasForeignKey(fk => fk.AddressLoadingId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<DrivingRoute>()     // 1 -> many
                .HasOne(au => au.AddressUnloading)
                .WithMany(dr => dr.AddressUnloading)
                .HasForeignKey(fk => fk.AddressUnloadingId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AddressPoint>();
        }
    }
}