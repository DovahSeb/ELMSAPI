using AutoMapper;
using ELMSAPI.Application.LeaveStatuses.DTOs;
using ELMSAPI.Domain.Models;

namespace ELMSAPI.Infrastructure.Mapping;

internal class LeaveStatusMappingProfile : Profile
{
    public LeaveStatusMappingProfile()
    {
        CreateMap<LeaveStatus, LeaveStatusResponseDto>();
    }
}
