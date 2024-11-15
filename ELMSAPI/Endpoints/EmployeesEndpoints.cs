using ELMSAPI.Application.Employees.Commands.CreateEmployee;
using ELMSAPI.Application.Employees.Commands.UpdateEmployee;
using ELMSAPI.Application.Employees.DTOs;
using ELMSAPI.Application.Employees.Queries.GetEmployeeById;
using ELMSAPI.Application.Employees.Queries.GetEmployees;
using MediatR;

namespace ELMSAPI.Endpoints;

public static class EmployeesEndpoints
{
    public static WebApplication MapEmployeesEndpoints(this WebApplication app)
    {
        var root = app.MapGroup("/api/employees")
            .WithTags("Employees")
            .WithOpenApi();

        root.MapGet("/GetEmployees/", GetEmployees)
            .Produces<List<EmployeeResponseDto>>()
            .WithName("Get Drivers")
            .WithSummary("Get All Employees");

        root.MapGet("/GetEmployeeById/{id}", GetEmployeeById)
            .Produces<EmployeeResponseDto>()
            .WithName("Get Driver by Id")
            .WithSummary("Lookup an Employee by their Id");

        root.MapPost("/CreateEmployee/", CreateEmployee)
            .Produces<EmployeeResponseDto>(StatusCodes.Status201Created)
            .WithName("Create Employee")
            .WithSummary("Create an Employee");

        root.MapPut("/UpdateEmployee/{id}", UpdateEmployee)
            .Produces<EmployeeRequestDto>(StatusCodes.Status200OK)
            .WithName("Update Employee")
            .WithSummary("Update an Employee");

        return app;
    }

    public static async Task<IResult> GetEmployees(IMediator mediator)
    {
        return Results.Ok(await mediator.Send(new GetEmployeesQuery()));
    }

    public static async Task<IResult> GetEmployeeById(IMediator mediator, string id)
    {
        if (!TryParseUlid(id, out var ulid))
            throw new ArgumentOutOfRangeException(nameof(id), "The id is invalid");

        var employee = await mediator.Send(new GetEmployeeByIdQuery(ulid));
        return Results.Ok(employee);
    }

    public static async Task<IResult> CreateEmployee(IMediator mediator, CreateEmployeeCommand request)
    {
        var newEmployee = await mediator.Send(request);

        return Results.Created($"/employees/{newEmployee.Id}", newEmployee);
    }

    public static async Task<IResult> UpdateEmployee(IMediator mediator, string id, UpdateEmployeeCommand request)
    {
        if (!TryParseUlid(id, out var ulid))
            throw new ArgumentOutOfRangeException(nameof(id), "The id is invalid");

        var employee = await mediator.Send(CreateUpdateCommand(ulid, request));
        return Results.Ok(employee);
    }

    private static bool TryParseUlid(string id, out Ulid ulid) =>
    Ulid.TryParse(id, out ulid);

    private static UpdateEmployeeCommand CreateUpdateCommand(Ulid ulid, UpdateEmployeeCommand request) =>
        new(ulid, request.FirstName, request.LastName, request.Email, request.DateAdded, request.DepartmentId);
}
