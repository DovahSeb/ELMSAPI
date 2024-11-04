using ELMSAPI.Application.Common.Enums;
using ELMSAPI.Application.Common.Exceptions;
using ELMSAPI.Application.Employees.DTOs;
using MediatR;

namespace ELMSAPI.Application.Employees.Queries.GetEmployeeById;

public class GetEmployeeByIdHandler(IEmployeesRepository employeesRepository) : IRequestHandler<GetEmployeeByIdQuery, EmployeeResponseDto>
{
    public async Task<EmployeeResponseDto> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
    {
        var employee = await employeesRepository.GetEmployeeById(request.Id, cancellationToken);

        NotFoundException.ThrowIfNull(employee, EntityType.Employee);

        return employee;
    }
}
