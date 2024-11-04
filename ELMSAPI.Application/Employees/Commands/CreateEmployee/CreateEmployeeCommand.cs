using ELMSAPI.Application.Employees.DTOs;
using MediatR;

namespace ELMSAPI.Application.Employees.Commands.CreateEmployee;

public record CreateEmployeeCommand(string FirstName, string LastName, string Email, DateTime DateJoined, int DepartmentId) : IRequest<EmployeeResponseDto>;