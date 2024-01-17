using FluentValidation;
using LogisticsManagementSystem.Domain;

namespace LogisticsManagementSystem.Application;

public class CreateEmployeeCommandValidator : AbstractValidator<CreateEmployeeCommand>
{
    public CreateEmployeeCommandValidator(IEmployeesRepository employeesRepository)
    {
        RuleFor(x => x.userName)
            .NotNull().NotEmpty().WithMessage("用户不能为空")
            .MustAsync((userName, _) => employeesRepository.EmployeeExistsAsync(userName)).WithMessage("用户已存在");
        RuleFor(x => x.password).NotNull().NotEmpty().WithMessage("密码不能为空");
        RuleFor(x => x)
                .Must(x => x.password == x.confirmPassword)
                .WithMessage("两次密码不一致");
    }
}
