namespace ELMSAPI.Application.Employees.DTOs;

public record EmployeeRequestDto (string FirstName, string LastName, string Email, DateTime DateJoined, int DepartmentId);