using ELMSAPI.Application.LeaveTypes.DTOs;
using MediatR;

namespace ELMSAPI.Application.LeaveTypes.Queries.GetLeaveTypes;

public record GetLeaveTypesQuery : IRequest<List<LeaveTypeResponseDto>>;
