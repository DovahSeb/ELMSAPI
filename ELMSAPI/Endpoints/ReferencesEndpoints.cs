using ELMSAPI.Application.LeaveStatuses.DTOs;
using ELMSAPI.Application.LeaveStatuses.Queries.GetLeaveStatuses;
using ELMSAPI.Application.LeaveTypes.Queries.GetLeaveTypes;
using ELMSAPI.Exceptions;
using MediatR;

namespace ELMSAPI.Endpoints;

public static class ReferencesEndpoints
{
    public static WebApplication MapReferencesEndpoints(this WebApplication app)
    {
        var root = app.MapGroup("/api/references")
            .WithTags("References")
            .WithOpenApi();

        root.MapGet("/GetLeaveStatuses/", GetLeaveStatuses)
            .Produces<List<LeaveStatusResponseDto>>()
            .WithName("Get Leave Statuses")
            .WithSummary("Get Leave Statuses Reference Values");

        root.MapGet("/GetLeaveTypes/", GetLeaveTypes)
            .Produces<List<LeaveStatusResponseDto>>()
            .WithName("Get Leave Types")
            .WithSummary("Get Leave Types Reference Values");

        return app;
    }

    public static async Task<IResult> GetLeaveStatuses(IMediator mediator)
    {
        try
        {
            return Results.Ok(await mediator.Send(new GetLeaveStatusesQuery()));
        } 
        catch
        {
            throw new ReferencesNotFoundException("LeaveStatuses");
        }
    }

    public static async Task<IResult> GetLeaveTypes(IMediator mediator)
    {
        try
        {
            return Results.Ok(await mediator.Send(new GetLeaveTypesQuery()));
        }
        catch
        {
            throw new ReferencesNotFoundException("LeaveTypes");
        }
    }
}
