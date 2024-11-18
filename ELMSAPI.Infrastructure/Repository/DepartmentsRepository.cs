using ELMSAPI.Application.Departments;
using ELMSAPI.Application.Departments.DTOs;
using ELMSAPI.Infrastructure.Database;
using ELMSAPI.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;

namespace ELMSAPI.Infrastructure.Repository;

public sealed class DepartmentsRepository : IDepartmentsRepository
{
    private readonly DatabaseContext _context;

    public DepartmentsRepository(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<List<DepartmentResponseDto>> GetDepartments(CancellationToken cancellationToken)
    {
        var departments = await _context.Departments
            .Where(x => !x.Status.Equals("D"))
            .AsNoTracking()
            .ToListAsync(cancellationToken);

        var departmentDto = departments
            .Select(x => x.MapToDepartmentResponseDto())
            .ToList();

        if (departmentDto.Count ==  0)
        {
            return [];
        }

        return departmentDto;
    }
}
