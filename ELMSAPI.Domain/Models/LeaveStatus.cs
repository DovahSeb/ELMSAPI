namespace ELMSAPI.Domain.Models;
public class LeaveStatus
{
    public required int Id { get; init; }
    public required string Description { get; init; }
    public DateTime DateCreated { get; init; }
    public DateTime DateModified { get; set; }
    public required string Status { get; set; }
}
