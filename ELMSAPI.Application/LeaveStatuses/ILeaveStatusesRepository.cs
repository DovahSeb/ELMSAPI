using ELMSAPI.Application.LeaveStatuses.DTOs;

namespace ELMSAPI.Application.LeaveStatuses;

public interface ILeaveStatusesRepository
{
    Task<List<LeaveStatusResponseDto>> GetLeaveStatuses(CancellationToken cancellationToken);
}