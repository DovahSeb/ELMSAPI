using ELMSAPI.Application.Employees.DTOs;
using MediatR;

namespace ELMSAPI.Application.Employees.Commands.UpdateEmployee;
public sealed class UpdateEmployeeHandler(IEmployeesRepository employeesRepository) : IRequestHandler<UpdateEmployeeCommand, EmployeeResponseDto>
{
    public async Task<EmployeeResponseDto> Handle(UpdateEmployeeCommand command, CancellationToken cancellationToken)
    {
        var employee = new EmployeeRequestDto
        {
            FirstName = command.FirstName,
            LastName = command.LastName,
            Email = command.Email,
            DateAdded = command.DateAdded,
            DepartmentId = command.DepartmentId,
        };
        return await employeesRepository.UpdateEmployee(command.Id, employee, cancellationToken);
    }
}
