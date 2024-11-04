using ELMSAPI.Application.Employees.DTOs;
using MediatR;

namespace ELMSAPI.Application.Employees.Queries.GetEmployees;

public class GetEmployeesHandler(IEmployeesRepository employeesRepository) : IRequestHandler<GetEmployeesQuery, List<EmployeeResponseDto>>
{
    public async Task<List<EmployeeResponseDto>> Handle(GetEmployeesQuery request, CancellationToken cancellationToken)
    {
        return await employeesRepository.GetEmployees(cancellationToken);
    }
}
