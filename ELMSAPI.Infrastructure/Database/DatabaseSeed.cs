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

        modelBuilder.Entity<Department>().HasData(
            new Department { Id = 1, Name = "Office of the Minister", DateCreated = fixedDate, DateModified = fixedDate, Status = "I" },
            new Department { Id = 2, Name = "Office of Secretary of State ", DateCreated = fixedDate, DateModified = fixedDate, Status = "I" },
            new Department { Id = 3, Name = "Accounts", DateCreated = fixedDate, DateModified = fixedDate, Status = "I" },
            new Department { Id = 4, Name = "Asset Management Unit", DateCreated = fixedDate, DateModified = fixedDate, Status = "I" },
            new Department { Id = 5, Name = "Debt Management Unit", DateCreated = fixedDate, DateModified = fixedDate, Status = "I" },
            new Department { Id = 6, Name = "Procurement Oversight Unity (POU)", DateCreated = fixedDate, DateModified = fixedDate, Status = "I" },
            new Department { Id = 7, Name = "Macro-Economic Forecasting Analyst Branch (MFAB)", DateCreated = fixedDate, DateModified = fixedDate, Status = "I" },
            new Department { Id = 8, Name = "Human Resources", DateCreated = fixedDate, DateModified = fixedDate, Status = "I" },
            new Department { Id = 9, Name = "Administration", DateCreated = fixedDate, DateModified = fixedDate, Status = "I" },
            new Department { Id = 10, Name = "System Support", DateCreated = fixedDate, DateModified = fixedDate, Status = "I" },
            new Department { Id = 11, Name = "Financial Planning and Control", DateCreated = fixedDate, DateModified = fixedDate, Status = "I" },
            new Department { Id = 12, Name = "Public Investment Management", DateCreated = fixedDate, DateModified = fixedDate, Status = "I" },
            new Department { Id = 13, Name = "Public Budget Management", DateCreated = fixedDate, DateModified = fixedDate, Status = "I" },
            new Department { Id = 14, Name = "Public Accounts Management", DateCreated = fixedDate, DateModified = fixedDate, Status = "I" },
            new Department { Id = 15, Name = "Treasury", DateCreated = fixedDate, DateModified = fixedDate, Status = "I" },
            new Department { Id = 16, Name = "Tax & Sectorial Policy", DateCreated = fixedDate, DateModified = fixedDate, Status = "I" },
            new Department { Id = 17, Name = "Financial Services Development", DateCreated = fixedDate, DateModified = fixedDate, Status = "I" },
            new Department { Id = 18, Name = "Internal Audit", DateCreated = fixedDate, DateModified = fixedDate, Status = "I" },
            new Department { Id = 19, Name = "Trade", DateCreated = fixedDate, DateModified = fixedDate, Status = "I" },
            new Department { Id = 20, Name = "National Planning", DateCreated = fixedDate, DateModified = fixedDate, Status = "I" }
            );
    }
}
