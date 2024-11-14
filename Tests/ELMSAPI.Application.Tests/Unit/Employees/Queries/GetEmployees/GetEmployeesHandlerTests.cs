using ELMSAPI.Application.Employees;
using ELMSAPI.Application.Employees.DTOs;
using ELMSAPI.Application.Employees.Queries.GetEmployees;
using NSubstitute;

namespace ELMSAPI.Application.Tests.Unit.Employees.Queries.GetEmployees;

public class GetEmployeesHandlerTests
{
    [Fact]
    public async Task Handle_ShouldPassThrough_Query()
    {
        //Arrange
        var query = new GetEmployeesQuery();
        var context = Substitute.For<IEmployeesRepository>();
        var handler = new GetEmployeesHandler(context);
        var token = new CancellationTokenSource().Token;

        context.GetEmployees(token)
            .Returns([new EmployeeResponseDto { Id = Ulid.NewUlid(), FirstName = "John", LastName = "Doe", Email = "john.doe@finance.gov.sc", Department = "Office of the Minister", IsActive = true }]);

        //Act
        var result = await handler.Handle(query, token);

        //Assert
        await context.Received(1).GetEmployees(token);

        Assert.NotNull(result);
        Assert.IsType<List<EmployeeResponseDto>>(result);

        Assert.NotEmpty(result);
        Assert.Single(result);
    }
}
