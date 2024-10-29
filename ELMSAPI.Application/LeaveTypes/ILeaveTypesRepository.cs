using ELMSAPI.Application.LeaveTypes.DTOs;

namespace ELMSAPI.Application.LeaveTypes;

public interface ILeaveTypesRepository
{
    Task<List<LeaveTypeResponseDto>> GetLeaveTypes(CancellationToken cancellationToken);
}
