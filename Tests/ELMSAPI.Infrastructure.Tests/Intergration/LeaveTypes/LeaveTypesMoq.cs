using AutoMapper;
using ELMSAPI.Application.LeaveTypes;
using ELMSAPI.Application.LeaveTypes.DTOs;
using ELMSAPI.Domain.Models;
using Moq;

namespace ELMSAPI.Infrastructure.Tests.Intergration.LeaveTypes;

public class LeaveTypesMoq
{
    public static ILeaveTypesRepository GetLeaveTypesRepository()
    {
        var mapperConfig = new MapperConfiguration(cfg => cfg.AddProfile<LeaveTypeMappingProfile>());
        var mapper = mapperConfig.CreateMapper();

        var moq = new Mock<ILeaveTypesRepository>();
        moq.Setup(x => x.GetLeaveTypes(It.IsAny<CancellationToken>())).ReturnsAsync(() => mapper.Map<List<LeaveTypeResponseDto>>(LeaveTypes));
        return moq.Object;
    }

    public static List<LeaveType> LeaveTypes = new List<LeaveType>
    {
        new () { Id = 1, Type = "Annual", Status = "I" },
        new () { Id = 2, Type = "Sick", Status = "I" },
        new () { Id = 3, Type = "Maternity", Status = "I" },
        new () { Id = 4, Type = "Paternity", Status = "I"},
        new () { Id = 5, Type = "Unpaid", Status = "I"}
    };

    public class LeaveTypeMappingProfile : Profile
    {
        public LeaveTypeMappingProfile()
        {
            CreateMap<LeaveType, LeaveTypeResponseDto>();
        }
    }
}
