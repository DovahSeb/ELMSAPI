using ELMSAPI.Application.Departments.DTOs;

namespace ELMSAPI.Application.Departments;

public interface IDepartmentsRepository
{
    Task<List<DepartmentResponseDto>> GetDepartments(CancellationToken cancellationToken);
}
