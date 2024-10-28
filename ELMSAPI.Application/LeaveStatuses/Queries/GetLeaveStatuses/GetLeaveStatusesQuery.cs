using ELMSAPI.Application.LeaveStatuses.DTOs;
using MediatR;

namespace ELMSAPI.Application.LeaveStatuses.Queries.GetLeaveStatuses;

public record GetLeaveStatusesQuery : IRequest<List<LeaveStatusResponseDto>>;
