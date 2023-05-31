using Microsoft.EntityFrameworkCore;

using Hakaton.Core;

namespace Hakaton.Infrastructure
{
    public partial class DatabaseContext : DbContext
    {
        public DbSet<Device> Devices { get; set; } = null!;
        public DbSet<DeviceAction> DeviceActions { get; set; } = null!;
        public DbSet<DeviceType> DeviceTypes { get; set; } = null!;
        public DbSet<Home> Homes { get; set; } = null!;
        public DbSet<Room> Rooms { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;


        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SeedData(modelBuilder);



            ApplyConfigurations(modelBuilder);
        }
    }
}