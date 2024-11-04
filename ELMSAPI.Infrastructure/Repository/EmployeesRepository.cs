using ELMSAPI.Application.Employees;
using ELMSAPI.Application.Employees.DTOs;
using ELMSAPI.Domain.Models;
using ELMSAPI.Infrastructure.Database;
using ELMSAPI.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;

namespace ELMSAPI.Infrastructure.Repository;

public sealed class EmployeesRepository : IEmployeesRepository
{
    private readonly DatabaseContext _context;

    public EmployeesRepository(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<List<EmployeeResponseDto>> GetEmployees(CancellationToken cancellationToken)
    {
        var employees = await _context.Employees
            .Where(x => !x.Status.Equals("D"))
            .Include(x => x.User)
            .Include(x => x.Department)
            .AsNoTracking()
            .ToListAsync(cancellationToken);

        var employeesDto = employees
            .Select(x => x.MapToEmployeeResponseDto())
            .ToList();

        return employeesDto;
    }

    public async Task<EmployeeResponseDto> GetEmployeeById(Ulid id, CancellationToken cancellationToken)
    {
        var employee = await _context.Employees
            .Where(x => x.Id == id)
            .Include(x => x.User)
            .Include(x => x.Department)
            .AsNoTracking()
            .FirstOrDefaultAsync(cancellationToken);

        var employeeDto = employee.MapToEmployeeResponseDto();

        return employeeDto;
    }

    public async Task<EmployeeResponseDto> CreateEmployee(EmployeeRequestDto employee, CancellationToken cancellationToken)
    {
        var userId = await GetUserIdByEmail(employee.Email);

        var newEmployee = new Employee 
        {
            Id = Ulid.NewUlid(),
            FirstName = employee.FirstName,
            LastName = employee.LastName,
            DateJoined = employee.DateJoined.Date,
            UserId = userId,
            DepartmentId = employee.DepartmentId,
            DateCreated = DateTime.Now,
            DateModified = DateTime.Now,
            Status = "I",
        };

        _context.Employees.Add(newEmployee);
        await _context.SaveChangesAsync(cancellationToken);

        return await GetEmployeeById(newEmployee.Id, cancellationToken);
    }

    public async Task<string> GetUserIdByEmail(string email)
    {
        var user = await _context.Users
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Email == email);

        if(user is null)
        {
            return string.Empty;
        }

        return user.Id;
    }
}
