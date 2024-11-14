namespace ELMSAPI.Domain.Models;

public class LeaveApplication
{
    public required int Id { get; set; }
    public required Ulid EmployeeId { get; set; }
    public Employee Employee { get; set; } = null!;
    public required int LeaveTypeId { get; set; }
    public LeaveType LeaveType { get; set; } = null!;
    public required DateTime StartDate { get; set; }
    public required DateTime EndDate { get; set; }
    public int TotalDays { get; set; }
    public required int LeaveStatusId { get; set; }
    public LeaveStatus LeaveStatus { get; set; } = null!;
    public required DateTime SubmittedDate { get; set; }
}
