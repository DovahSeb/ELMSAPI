using ELMSAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ELMSAPI.Infrastructure.Database;
public static class DatabaseSeed
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        var fixedDate = new DateTime(2024, 10, 29);

        modelBuilder.Entity<LeaveStatus>().HasData(
            new LeaveStatus { Id = 1, Description = "Pending", DateCreated = fixedDate, DateModified = fixedDate, Status = "I" },
            new LeaveStatus { Id = 2, Description = "Approved", DateCreated = fixedDate, DateModified = fixedDate, Status = "I" },
            new LeaveStatus { Id = 3, Description = "Rejected", DateCreated = fixedDate, DateModified = fixedDate, Status = "I" }
        );

        modelBuilder.Entity<LeaveType>().HasData(
            new LeaveType { Id = 1, Type = "Annual", DateCreated = fixedDate, DateModified = fixedDate, Status = "I" },
            new LeaveType { Id = 2, Type = "Sick", DateCreated = fixedDate, DateModified = fixedDate, Status = "I" },
            new LeaveType { Id = 3, Type = "Maternity", DateCreated = fixedDate, DateModified = fixedDate, Status = "I" },
            new LeaveType { Id = 4, Type = "Paternity", DateCreated = fixedDate, DateModified = fixedDate, Status = "I" },
            new LeaveType { Id = 5, Type = "Unpaid", DateCreated = fixedDate, DateModified = fixedDate, Status = "I" }
        );
    }
}
