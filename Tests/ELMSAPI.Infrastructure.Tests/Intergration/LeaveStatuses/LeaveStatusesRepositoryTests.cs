using ELMSAPI.Application.LeaveStatuses;
using ELMSAPI.Application.LeaveStatuses.DTOs;
using ELMSAPI.Application.LeaveStatuses.Queries.GetLeaveStatuses;

namespace ELMSAPI.Infrastructure.Tests.Intergration.LeaveStatuses;

public class LeaveStatusesRepositoryTests
{
    private readonly ILeaveStatusesRepository _leaveStatusesRepository;
    private GetLeaveStatusesQuery _handler;

    public LeaveStatusesRepositoryTests()
    {
        _leaveStatusesRepository = LeaveStatusesMoq.GetLeaveStatusesRepository();
        _handler = new GetLeaveStatusesQuery();
    }

    [Fact]
    public async Task GetLeaveStatuses_ReturnsListOfLeaveStatuses()
    {
        var cancellationToken = new CancellationToken();

        var result = await _leaveStatusesRepository.GetLeaveStatuses(cancellationToken);

        Assert.NotNull(result);
        Assert.IsType<List<LeaveStatusResponseDto>>(result);
        Assert.Equal(3, result.Count);
    }
}
