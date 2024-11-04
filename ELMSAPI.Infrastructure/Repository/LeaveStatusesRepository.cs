using AutoMapper;
using ELMSAPI.Application.LeaveStatuses;
using ELMSAPI.Application.LeaveStatuses.DTOs;
using ELMSAPI.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace ELMSAPI.Infrastructure.Repository;
public sealed class LeaveStatusesRepository : ILeaveStatusesRepository
{
    private readonly DatabaseContext _context;
    private readonly IMapper _mapper;

    public LeaveStatusesRepository(DatabaseContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<LeaveStatusResponseDto>> GetLeaveStatuses(CancellationToken cancellationToken)
    {
        var leaveStatuses = await _context.LeaveStatuses
            .Where(x => !x.Status.Equals("D"))
            .AsNoTracking()
            .ToListAsync(cancellationToken);

        if (leaveStatuses.Count == 0)
        {
            return [];
        }

        return _mapper.Map<List<LeaveStatusResponseDto>>(leaveStatuses);
    }
}
