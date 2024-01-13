using ErrorOr;
using LogisticsManagementSystem.Domain;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace LogisticsManagementSystem.Application;

public class SetEmployeeCommandHandler : IRequestHandler<SetEmployeeCommand, ErrorOr<IdentityResult>>
{
    private readonly IEmployeesRepository _employeesRepository;

    public SetEmployeeCommandHandler(IEmployeesRepository employeesRepository)
    {
        _employeesRepository = employeesRepository;
    }
    public async Task<ErrorOr<IdentityResult>> Handle(SetEmployeeCommand command, CancellationToken cancellationToken)
    {
        var employee = new Employee(
                  command.userName,
                  command?.phoneNumber
              );

        var user = await _employeesRepository.CreateAsync(employee, command.password);
        if (user is null)
            return Error.Unexpected(description: "服务器异常");
        return user;
    }

}