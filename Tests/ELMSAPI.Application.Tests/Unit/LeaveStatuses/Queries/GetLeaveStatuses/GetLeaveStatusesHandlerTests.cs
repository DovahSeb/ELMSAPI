using ELMSAPI.Application.LeaveStatuses;
using ELMSAPI.Application.LeaveStatuses.DTOs;
using ELMSAPI.Application.LeaveStatuses.Queries.GetLeaveStatuses;
using NSubstitute;

namespace ELMSAPI.Application.Tests.Unit.LeaveStatuses.Queries.GetLeaveStatuses;

public class GetLeaveStatusesHandlerTests
{
    [Fact]
    public async Task Handle_ShouldPassThrough_Query()
    {
        //Arrange
        var query = new GetLeaveStatusesQuery();
        var context = Substitute.For<ILeaveStatusesRepository>();
        var handler = new GetLeaveStatusesHandler(context);
        var token = new CancellationTokenSource().Token;

        context.GetLeaveStatuses(token).Returns([new LeaveStatusResponseDto(1, "Pending")]);

        //Act
        var result = await handler.Handle(query, token);

        //Assert
        await context.Received(1).GetLeaveStatuses(token);

        Assert.NotNull(result);
        Assert.IsType<List<LeaveStatusResponseDto>>(result);
        Assert.NotEmpty(result);
        Assert.Single(result);
        Assert.Equal(1, result[0].Id);
        Assert.Equal("Pending", result[0].Description);
    }
}
