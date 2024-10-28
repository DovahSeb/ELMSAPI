using ELMSAPI.Application.LeaveTypes;
using ELMSAPI.Application.LeaveTypes.DTOs;
using ELMSAPI.Application.LeaveTypes.Queries.GetLeaveTypes;

namespace ELMSAPI.Infrastructure.Tests.Intergration.LeaveTypes;

public class LeaveTypesRepositoryTests
{
    private readonly ILeaveTypesRepository _leaveTypesRepository;
    private GetLeaveTypesQuery _handler;

    public LeaveTypesRepositoryTests()
    {
        _leaveTypesRepository = LeaveTypesMoq.GetLeaveTypesRepository();
        _handler = new GetLeaveTypesQuery();
    }

    [Fact]
    public async Task GetLeaveStatuses_ReturnsListOfLeaveStatuses()
    {
        var cancellationToken = new CancellationToken();

        var result = await _leaveTypesRepository.GetLeaveTypes(cancellationToken);

        Assert.NotNull(result);
        Assert.IsType<List<LeaveTypeResponseDto>>(result);
        Assert.Equal(5, result.Count);
    }
}
