namespace ELMSAPI.Domain.Models;

public class Employee : Entity
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required DateTime DateAdded { get; set; }
    public required int DepartmentId { get; set; }
    public Department Department { get; set; } = null!;
    public required bool IsActive { get; set; }
}
