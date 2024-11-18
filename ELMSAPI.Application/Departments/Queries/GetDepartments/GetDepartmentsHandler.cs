using ELMSAPI.Application.Departments.DTOs;
using MediatR;

namespace ELMSAPI.Application.Departments.Queries.GetDepartments;

public class GetDepartmentsHandler(IDepartmentsRepository departmentsRepository) : IRequestHandler<GetDepartmentsQuery, List<DepartmentResponseDto>>
{
    public async Task<List<DepartmentResponseDto>> Handle(GetDepartmentsQuery query, CancellationToken cancellationToken)
    {
        return await departmentsRepository.GetDepartments(cancellationToken);
    }
}
