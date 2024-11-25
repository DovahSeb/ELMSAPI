using ELMSAPI.Application.Employees;
using ELMSAPI.Application.Employees.Commands.UpdateEmployee;
using ELMSAPI.Application.Employees.DTOs;
using NSubstitute;

namespace ELMSAPI.Application.Tests.Unit.Employees.Commands.UpdateEmployee;

public class UpdateEmployeeHandlerTests
{
    [Fact]
    public async Task Handle_ShouldPassThrough_Command()
    {
        //Arrange
        var command = new UpdateEmployeeCommand(Ulid.NewUlid(), "John", "Doe", "j.doe@finance.gov.sc", DateTime.Now.Date, 1);
        var context = Substitute.For<IEmployeesRepository>();
        var handler = new UpdateEmployeeHandler(context);
        var token = new CancellationTokenSource().Token;

        context.UpdateEmployee(command.Id, new EmployeeRequestDto { FirstName = command.FirstName, LastName = command.LastName, Email = command.Email, DateAdded = command.DateAdded, DepartmentId = command.DepartmentId}, token)
            .Returns(new EmployeeResponseDto { Id = Ulid.NewUlid(), FirstName = "John", LastName = "Doe", Email = "j.doe@finance.gov.sc", DateAdded = DateTime.Now.Date, Department = "Office of the Minister", IsActive = true });

        //Act
        var result = await handler.Handle(command, token);

        //Assert
        await context.Received(1).UpdateEmployee(command.Id, new EmployeeRequestDto { FirstName = command.FirstName, LastName = command.LastName, Email = command.Email, DateAdded = command.DateAdded, DepartmentId = command.DepartmentId }, token);

        Assert.NotNull(result);
        Assert.IsType<EmployeeResponseDto>(result);
        Assert.Equal(command.FirstName, result.FirstName);
        Assert.Equal(command.LastName, result.LastName);
        Assert.Equal(command.Email, result.Email);
        Assert.True(result.IsActive);
    }
}
