using ELMSAPI.Application.Employees.DTOs;

namespace ELMSAPI.Application.Employees;

public interface IEmployeesRepository
{
    Task<List<EmployeeResponseDto>> GetEmployees(CancellationToken cancellationToken);
    Task<EmployeeResponseDto> GetEmployeeById(Ulid id, CancellationToken cancellationToken);
    Task<EmployeeResponseDto> CreateEmployee(EmployeeRequestDto employee, CancellationToken cancellationToken);
}
