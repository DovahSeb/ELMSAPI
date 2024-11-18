using ELMSAPI.Application.Departments;
using ELMSAPI.Application.Departments.DTOs;
using ELMSAPI.Application.Departments.Queries.GetDepartments;
using NSubstitute;

namespace ELMSAPI.Application.Tests.Unit.Departments.Queries.GetDepartments;

public class GetDepartmentsHandlerTests
{
    [Fact]
    public async Task Handle_ShouldPassThrough_Query()
    {
        //Arrange
        var query = new GetDepartmentsQuery();
        var context = Substitute.For<IDepartmentsRepository>();
        var handler = new GetDepartmentsHandler(context);
        var token = new CancellationTokenSource().Token;

        context.GetDepartments(token).Returns([new DepartmentResponseDto(1, "Office of the Minister")]);

        //Act
        var result = await handler.Handle(query, token);

        //Assert
        await context.Received(1).GetDepartments(token);

        Assert.NotNull(result);
        Assert.IsType<List<DepartmentResponseDto>>(result);
        Assert.NotEmpty(result);
        Assert.Single(result);
        Assert.Equal(1, result[0].Id);
        Assert.Equal("Office of the Minister", result[0].Name);
    }
}
