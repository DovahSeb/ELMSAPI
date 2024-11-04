using AutoMapper;
using ELMSAPI.Application.LeaveStatuses.DTOs;
using ELMSAPI.Application.LeaveTypes;
using ELMSAPI.Application.LeaveTypes.DTOs;
using ELMSAPI.Domain.Models;
using ELMSAPI.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace ELMSAPI.Infrastructure.Repository;

public sealed class LeaveTypesRepository : ILeaveTypesRepository
{
    private readonly DatabaseContext _context;
    private readonly IMapper _mapper;

    public LeaveTypesRepository(DatabaseContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<LeaveTypeResponseDto>> GetLeaveTypes(CancellationToken cancellationToken)
    {
        var leaveTypes = await _context.LeaveTypes
            .Where(x => !x.Status.Equals("D"))
        .AsNoTracking()
            .ToListAsync(cancellationToken);

        if (leaveTypes.Count == 0)
        {
            return [];
        }

        return _mapper.Map<List<LeaveTypeResponseDto>>(leaveTypes);
    }
}
