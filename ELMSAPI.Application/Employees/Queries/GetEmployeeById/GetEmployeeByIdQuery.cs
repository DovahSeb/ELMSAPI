using ELMSAPI.Application.Employees.DTOs;
using MediatR;

namespace ELMSAPI.Application.Employees.Queries.GetEmployeeById;

public record GetEmployeeByIdQuery(Ulid Id) : IRequest<EmployeeResponseDto>;

