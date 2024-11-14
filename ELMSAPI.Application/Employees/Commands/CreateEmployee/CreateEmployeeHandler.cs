using ELMSAPI.Application.Employees.DTOs;
using MediatR;

namespace ELMSAPI.Application.Employees.Commands.CreateEmployee;

public sealed class CreateEmployeeHandler(IEmployeesRepository employeesRepository) : IRequestHandler<CreateEmployeeCommand, EmployeeResponseDto>
{
    public async Task<EmployeeResponseDto> Handle(CreateEmployeeCommand command, CancellationToken cancellationToken)
    {
        var newEmployee = new EmployeeRequestDto { 
            FirstName = command.FirstName, 
            LastName = command.LastName, 
            Email = command.Email, 
            DateJoined = command.DateJoined, 
            DepartmentId = command.DepartmentId 
        };
        return await employeesRepository.CreateEmployee(newEmployee, cancellationToken);
    }
}
