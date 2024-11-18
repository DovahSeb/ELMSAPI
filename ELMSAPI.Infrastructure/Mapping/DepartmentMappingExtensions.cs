using ELMSAPI.Application.Departments.DTOs;
using ELMSAPI.Domain.Models;

namespace ELMSAPI.Infrastructure.Mapping;

public static class DepartmentMappingExtensions
{
    public static DepartmentResponseDto MapToDepartmentResponseDto(this Department department)
    {
        return new DepartmentResponseDto(department.Id, department.Name);
    }
}
