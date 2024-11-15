using ELMSAPI.Application.Employees.DTOs;
using MediatR;

namespace ELMSAPI.Application.Employees.Commands.CreateEmployee;

public sealed record CreateEmployeeCommand(string FirstName, string LastName, string Email, DateTime DateAdded, int DepartmentId) : IRequest<EmployeeResponseDto>;