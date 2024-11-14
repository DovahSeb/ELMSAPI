using ELMSAPI.Domain.Models;
using ELMSAPI.Infrastructure.Extensions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ELMSAPI.Infrastructure.Database;
public class DatabaseContext : IdentityDbContext<User>
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<LeaveAllowance> LeaveAllowances { get; set; }
    public DbSet<LeaveApplication> LeaveApplications { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<LeaveStatus> LeaveStatuses { get; set; }
    public DbSet<LeaveType> LeaveTypes { get; set; }

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

        modelBuilder.Entity<User>().ToTable("Users");

        DatabaseSeed.Seed(modelBuilder);
    }
}
