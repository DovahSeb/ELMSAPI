namespace ELMSAPI.Domain.Models;

public class Employee : Entity
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required DateTime DateJoined { get; set; }

    public required string UserId { get; set; }
    public User User { get; set; } = null!;
    public required int DepartmentId { get; set; }
    public Department Department { get; set; } = null!;
}
