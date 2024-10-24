using ELMSAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ELMSAPI.Infrastructure.Database;
public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

    public DbSet<LeaveStatus> LeaveStatuses { get; set; }
    public DbSet<LeaveType> LeaveTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        DatabaseSeed.Seed(modelBuilder);
    }
}
