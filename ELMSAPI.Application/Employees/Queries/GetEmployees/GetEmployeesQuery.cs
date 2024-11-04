using ELMSAPI.Application.Employees.DTOs;
using MediatR;

namespace ELMSAPI.Application.Employees.Queries.GetEmployees;

public record GetEmployeesQuery : IRequest<List<EmployeeResponseDto>>;
