using ELMSAPI.Application.Employees;
using ELMSAPI.Application.Employees.Commands.CreateEmployee;
using ELMSAPI.Application.Employees.DTOs;
using NSubstitute;

namespace ELMSAPI.Application.Tests.Unit.Employees.Commands.CreateEmployee;

public class CreateEmployeeHandlerTests
{
    [Fact]
    public async Task Handle_ShouldPassThrough_Command()
    {
        //Arrange
        var command = new CreateEmployeeCommand("John", "Doe", "john.doe@finance.gov.sc", DateTime.Now.Date, 1);
        var context = Substitute.For<IEmployeesRepository>();
        var hanlder = new CreateEmployeeHandler(context);
        var token = new CancellationTokenSource().Token;

        context.CreateEmployee(new EmployeeRequestDto(command.FirstName, command.LastName, command.Email, command.DateJoined, command.DepartmentId), token)
            .Returns(new EmployeeResponseDto { Id = Ulid.NewUlid(), FirstName = "John", LastName = "Doe", Email = "john.doe@finance.gov.sc", Department = "Office of the Minister" });

        //Act
        var result = await hanlder.Handle(command, token);

        //Assert
        await context.Received(1).CreateEmployee(new EmployeeRequestDto(command.FirstName, command.LastName, command.Email, command.DateJoined, command.DepartmentId), token);

        Assert.NotNull(result);
        Assert.IsType<EmployeeResponseDto>(result);
        Assert.Equal(command.FirstName, result.FirstName);
        Assert.Equal(command.LastName, result.LastName);
        Assert.Equal(command.Email, result.Email);
    }
}
