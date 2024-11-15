using FluentValidation;

namespace ELMSAPI.Application.Employees.Commands.UpdateEmployee;

public class UpdateEmployeeCommandValidator : AbstractValidator<UpdateEmployeeCommand>
{
    public UpdateEmployeeCommandValidator()
    {
        RuleFor(p => p.FirstName)
            .NotEmpty();

        RuleFor(p => p.LastName)
            .NotEmpty();

        RuleFor(p => p.Email)
            .NotEmpty()
            .EmailAddress();

        RuleFor(p => p.DateAdded)
            .NotEmpty();

        RuleFor(p => p.DepartmentId)
            .NotNull();
    }
}
