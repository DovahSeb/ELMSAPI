using FluentValidation;

namespace ELMSAPI.Application.Employees.Commands.CreateEmployee;

public class CreateEmployeeCommandValidator : AbstractValidator<CreateEmployeeCommand>
{
    public CreateEmployeeCommandValidator()
    {
        RuleFor(p => p.FirstName)
            .NotEmpty();

        RuleFor(p => p.LastName)
            .NotEmpty();

        RuleFor(p => p.Email)
            .NotEmpty()
            .EmailAddress();

        RuleFor(p => p.DateJoined)
            .NotEmpty();

        RuleFor(p => p.DepartmentId)
            .NotNull();
    }
}
