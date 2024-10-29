using ELMSAPI.Application.LeaveTypes.DTOs;
using MediatR;

namespace ELMSAPI.Application.LeaveTypes.Queries.GetLeaveTypes;
public class GetLeaveTypesHandler(ILeaveTypesRepository repository) : IRequestHandler<GetLeaveTypesQuery, List<LeaveTypeResponseDto>>
{
    public async Task<List<LeaveTypeResponseDto>> Handle(GetLeaveTypesQuery request, CancellationToken cancellationToken)
    {
        return await repository.GetLeaveTypes(cancellationToken);
    }
}