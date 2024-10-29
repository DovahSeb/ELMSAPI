using ELMSAPI.Domain.Models;
using ELMSAPI.Infrastructure.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ELMSAPI.Infrastructure.Database;
public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

    public DbSet<LeaveStatus> LeaveStatuses { get; set; }
    public DbSet<LeaveType> LeaveTypes { get; set; }
    public DbSet<IdentityUser> Users { get; set; }
    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        base.ConfigureConventions(configurationBuilder);
        configurationBuilder
            .Properties<Ulid>()
            .HaveConversion<UlidToStringConverterExtensions.UlidToStringConverter>();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        DatabaseSeed.Seed(modelBuilder);
    }
}
