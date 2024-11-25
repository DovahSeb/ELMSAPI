using ELMSAPI.Application.Common.Exceptions;
using ELMSAPI.Application.Employees;
using ELMSAPI.Application.Employees.DTOs;
using ELMSAPI.Application.Employees.Queries.GetEmployeeById;
using NSubstitute;

namespace ELMSAPI.Application.Tests.Unit.Employees.Queries.GetEmployeeById;

public class GetEmployeeByIdHandlerTests
{
    [Fact]
    public async Task Handle_ShouldPassThrough_Query()
    {
        //Arrange
        var query = new GetEmployeeByIdQuery(Ulid.NewUlid());
        var context = Substitute.For<IEmployeesRepository>();
        var handler = new GetEmployeeByIdHandler(context);
        var token = new CancellationTokenSource().Token;

        context.GetEmployeeById(Arg.Any<Ulid>(), token)
            .Returns(new EmployeeResponseDto { Id = Ulid.NewUlid(), FirstName = "John", LastName = "Doe", Email = "john.doe@finance.gov.sc", DateAdded = DateTime.Now.Date, Department = "Office of the Minister", IsActive = true });

        //Act
        var result = await handler.Handle(query, token);

        //Assert
        await context.Received(1).GetEmployeeById(query.Id, token);

        Assert.NotNull(result);
        Assert.IsType<EmployeeResponseDto>(result);
        Assert.Equal("John", result.FirstName);
        Assert.Equal("Doe", result.LastName);
        Assert.Equal("john.doe@finance.gov.sc", result.Email);
        Assert.True(result.IsActive);
    }

    [Fact]
    public async Task Handle_ShouldThrowException_DoesNotExist()
    {
        //Arrange
        var query = new GetEmployeeByIdQuery(Ulid.NewUlid());
        var context = Substitute.For<IEmployeesRepository>();
        var handler = new GetEmployeeByIdHandler(context);
        var token = new CancellationTokenSource().Token;

        //Act & Assert
        var exception = await Assert.ThrowsAsync<NotFoundException>(async () => await handler.Handle(query, token));

        //Assert
        await context.Received(1).GetEmployeeById(query.Id, token);

        Assert.Equal("The Employee with the supplied id was not found", exception.Message);
    }
}
