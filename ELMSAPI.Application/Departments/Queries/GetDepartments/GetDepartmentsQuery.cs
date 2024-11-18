using ELMSAPI.Application.Departments.DTOs;
using MediatR;

namespace ELMSAPI.Application.Departments.Queries.GetDepartments;

public record GetDepartmentsQuery : IRequest<List<DepartmentResponseDto>>;
