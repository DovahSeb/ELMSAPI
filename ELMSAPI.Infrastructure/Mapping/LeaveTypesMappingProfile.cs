using AutoMapper;
using ELMSAPI.Application.LeaveTypes.DTOs;
using ELMSAPI.Domain.Models;

namespace ELMSAPI.Infrastructure.Mapping;

internal class LeaveTypesMappingProfile : Profile
{
    public LeaveTypesMappingProfile()
    {
        CreateMap<LeaveType, LeaveTypeResponseDto>();
    }
}
