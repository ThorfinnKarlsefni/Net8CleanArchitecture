using ErrorOr;
using MediatR;

namespace LogisticsManagementSystem.Application;

public class EmployeeLoginCommandHandler(IEmployeesRepository _employeesRepository) : IRequestHandler<EmployeeLoginCommand, ErrorOr<EmployeeInfo>>
{
    public async Task<ErrorOr<EmployeeInfo>> Handle(EmployeeLoginCommand command, CancellationToken cancellationToken)
    {
        var employee = await _employeesRepository.FindByNameAsync(command.UserName);
        if (employee is null)
        {
            return Error.Validation(description: "用户不存在");
        }

        var ok = await _employeesRepository.CheckPasswordAsync(employee, command.Password);
        if (!ok)
        {
            return Error.Validation(description: "用户名或密码错误");
        }
        var roles = await _employeesRepository.GetRolesAsync(employee);
        var employeeInfo = new EmployeeInfo(employee, roles);
        return employeeInfo;
    }
}
