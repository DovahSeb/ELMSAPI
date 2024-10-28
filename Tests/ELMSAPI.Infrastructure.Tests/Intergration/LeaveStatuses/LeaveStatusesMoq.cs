using AutoMapper;
using ELMSAPI.Application.LeaveStatuses;
using ELMSAPI.Application.LeaveStatuses.DTOs;
using ELMSAPI.Domain.Models;
using Moq;

namespace ELMSAPI.Infrastructure.Tests.Intergration.LeaveStatuses;
public class LeaveStatusesMoq
{
    public static ILeaveStatusesRepository GetLeaveStatusesRepository()
    {
        var mapperConfig = new MapperConfiguration(cfg => cfg.AddProfile<LeaveStatusMappingProfile>());
        var mapper = mapperConfig.CreateMapper();

        var moq = new Mock<ILeaveStatusesRepository>();
        moq.Setup(x => x.GetLeaveStatuses(It.IsAny<CancellationToken>())).ReturnsAsync(() => mapper.Map<List<LeaveStatusResponseDto>>(LeaveStatuses));
        return moq.Object;
    }

    public static List<LeaveStatus> LeaveStatuses = new List<LeaveStatus>
    {
        new () { Id = 1, Description = "Pending", Status = "I" },
        new () { Id = 2, Description = "Approved", Status = "I" },
        new () { Id = 3, Description = "Rejected", Status = "I" }
    };

    public class LeaveStatusMappingProfile : Profile
    {
        public LeaveStatusMappingProfile()
        {
            CreateMap<LeaveStatus, LeaveStatusResponseDto>();
        }
    }
}
