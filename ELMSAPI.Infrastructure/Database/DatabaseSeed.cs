using ELMSAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ELMSAPI.Infrastructure.Database;
public static class DatabaseSeed
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LeaveStatus>().HasData(
            new LeaveStatus { Id = 1, Description = "Pending", DateCreated = DateTime.Now, DateModified = DateTime.Now, Status = "I" },
            new LeaveStatus { Id = 2, Description = "Approved", DateCreated = DateTime.Now, DateModified = DateTime.Now, Status = "I" },
            new LeaveStatus { Id = 3, Description = "Rejected", DateCreated = DateTime.Now, DateModified = DateTime.Now, Status = "I" }
        );

        modelBuilder.Entity<LeaveType>().HasData(
            new LeaveType { Id = 1, Type = "Annual", DateCreated = DateTime.Now, DateModified = DateTime.Now, Status = "I" },
            new LeaveType { Id = 2, Type = "Sick", DateCreated = DateTime.Now, DateModified = DateTime.Now, Status = "I" },
            new LeaveType { Id = 3, Type = "Maternity", DateCreated = DateTime.Now, DateModified = DateTime.Now, Status = "I" }, 
            new LeaveType { Id = 4, Type = "Paternity", DateCreated = DateTime.Now, DateModified = DateTime.Now, Status = "I" },
            new LeaveType { Id = 5, Type = "Unpaid", DateCreated = DateTime.Now, DateModified = DateTime.Now, Status = "I" }
        );
    }
}
