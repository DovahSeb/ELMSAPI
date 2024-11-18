using ELMSAPI.Application.Departments.DTOs;
using ELMSAPI.Application.Departments.Queries.GetDepartments;
using ELMSAPI.Application.LeaveStatuses.DTOs;
using ELMSAPI.Application.LeaveStatuses.Queries.GetLeaveStatuses;
using ELMSAPI.Application.LeaveTypes.DTOs;
using ELMSAPI.Application.LeaveTypes.Queries.GetLeaveTypes;
using MediatR;

namespace ELMSAPI.Endpoints;

public static class ReferencesEndpoints
{
    public static WebApplication MapReferencesEndpoints(this WebApplication app)
    {
        var root = app.MapGroup("/api/references")
            .WithTags("References")
            .WithOpenApi();

        root.MapGet("/GetDepartments/", GetDepartments)
            .Produces<List<DepartmentResponseDto>>()
            .WithName("Get Departments")
            .WithSummary("Get Departments Reference Values");

        root.MapGet("/GetLeaveStatuses/", GetLeaveStatuses)
            .Produces<List<LeaveStatusResponseDto>>()
            .WithName("Get Leave Statuses")
            .WithSummary("Get Leave Statuses Reference Values");

        root.MapGet("/GetLeaveTypes/", GetLeaveTypes)
            .Produces<List<LeaveTypeResponseDto>>()
            .WithName("Get Leave Types")
            .WithSummary("Get Leave Types Reference Values");

        return app;
    }

    public static async Task<IResult> GetDepartments(IMediator mediator)
    {
        return Results.Ok(await mediator.Send(new GetDepartmentsQuery()));
    }

    public static async Task<IResult> GetLeaveStatuses(IMediator mediator)
    {
        return Results.Ok(await mediator.Send(new GetLeaveStatusesQuery()));
    }

    public static async Task<IResult> GetLeaveTypes(IMediator mediator)
    {
        return Results.Ok(await mediator.Send(new GetLeaveTypesQuery()));
    }
}
