namespace ELMSAPI.Application.Employees.DTOs;

public record EmployeeRequestDto 
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required DateTime DateAdded { get; set; }
    public required int DepartmentId { get; set; }
}