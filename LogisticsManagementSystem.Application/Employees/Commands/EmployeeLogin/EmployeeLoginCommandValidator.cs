using FluentValidation;

namespace LogisticsManagementSystem.Application;

public class EmployeeLoginCommandValidator : AbstractValidator<EmployeeLoginCommand>
{
    public EmployeeLoginCommandValidator()
    {
        RuleFor(x => x.UserName).NotEmpty().NotNull().WithMessage("用户名不能为空");
        RuleFor(x => x.Password).NotEmpty().NotNull().WithMessage("密码不能为空");
    }
}
