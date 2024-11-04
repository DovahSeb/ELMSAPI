using ELMSAPI.Application.Employees.DTOs;
using MediatR;

namespace ELMSAPI.Application.Employees.Commands.CreateEmployee;

public class CreateEmployeeHandler(IEmployeesRepository employeesRepository) : IRequestHandler<CreateEmployeeCommand, EmployeeResponseDto>
{
    public async Task<EmployeeResponseDto> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
    {
        var newEmployee = new EmployeeRequestDto(request.FirstName, request.LastName, request.Email, request.DateJoined, request.DepartmentId);
        return await employeesRepository.CreateEmployee(newEmployee, cancellationToken);
    }
}
