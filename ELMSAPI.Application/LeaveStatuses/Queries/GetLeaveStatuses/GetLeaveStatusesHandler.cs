using ELMSAPI.Application.LeaveStatuses.DTOs;
using MediatR;

namespace ELMSAPI.Application.LeaveStatuses.Queries.GetLeaveStatuses;

public class GetLeaveStatusesHandler(ILeaveStatusesRepository repository) : IRequestHandler<GetLeaveStatusesQuery, List<LeaveStatusResponseDto>>
{
    public async Task<List<LeaveStatusResponseDto>> Handle(GetLeaveStatusesQuery request, CancellationToken cancellationToken)
    {
        return await repository.GetLeaveStatuses(cancellationToken);
    }
}
