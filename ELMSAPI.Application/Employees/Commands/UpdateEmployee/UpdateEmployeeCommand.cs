using ELMSAPI.Application.Employees.DTOs;
using MediatR;

namespace ELMSAPI.Application.Employees.Commands.UpdateEmployee;

public sealed record UpdateEmployeeCommand(Ulid Id, string FirstName, string LastName, string Email, DateTime DateAdded, int DepartmentId) : IRequest<EmployeeResponseDto>;
