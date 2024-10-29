using ELMSAPI.Application.LeaveTypes;
using ELMSAPI.Application.LeaveTypes.DTOs;
using ELMSAPI.Application.LeaveTypes.Queries.GetLeaveTypes;
using NSubstitute;

namespace ELMSAPI.Application.Tests.Unit.LeaveTypes.Queries.GetLeaveTypes;

public class GetLeaveTypesHandlerTests
{
    [Fact]
    public async Task Handle_ShouldPassThrough_Query()
    {
        //Arrange
        var query = new GetLeaveTypesQuery();
        var context = Substitute.For<ILeaveTypesRepository>();
        var handler = new GetLeaveTypesHandler(context);
        var token = new CancellationTokenSource().Token;

        context.GetLeaveTypes(token).Returns([new LeaveTypeResponseDto(1, "Annual")]);

        //Act
        var result = await handler.Handle(query, token);

        //Assert
        await context.Received(1).GetLeaveTypes(token);

        Assert.NotNull(result);
        Assert.IsType<List<LeaveTypeResponseDto>>(result);
        Assert.NotEmpty(result);
        Assert.Single(result);
        Assert.Equal(1, result[0].Id);
        Assert.Equal("Annual", result[0].Type);
    }
}