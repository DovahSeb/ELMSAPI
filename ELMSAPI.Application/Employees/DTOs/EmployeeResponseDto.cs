namespace ELMSAPI.Application.Employees.DTOs;

public record EmployeeResponseDto 
{
    public required Ulid Id { get; init; }
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public required string Email { get; init; }
    public required string Department { get; init; }
    public required bool IsActive { get; init; }
}