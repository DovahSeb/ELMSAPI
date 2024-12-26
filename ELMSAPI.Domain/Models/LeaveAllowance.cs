namespace ELMSAPI.Domain.Models;

public class LeaveAllowance
{
    public required int Id { get; set; }
    public required Ulid EmployeeId { get; set; }
    public Employee Employee { get; set; } = null!;
    public required float InitialLeaveAllowance { get; set; }
    public required float CompletedMonthAllowance { get; set; }
    public required float TotalLeaveAllowance {  get; set; }
    public required float RemainingLeaveAllowance { get; set; }
    public required string Status { get; set; }
}