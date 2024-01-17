using ErrorOr;
using LogisticsManagementSystem.Domain;
using MediatR;

namespace LogisticsManagementSystem.Application;

public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, ErrorOr<Created>>
{
    private readonly IEmployeesRepository _employeesRepository;

    public CreateEmployeeCommandHandler(IEmployeesRepository employeesRepository)
    {
        _employeesRepository = employeesRepository;
    }
    public async Task<ErrorOr<Created>> Handle(CreateEmployeeCommand command, CancellationToken cancellationToken)
    {
        var employee = new Employee(
                  command.userName,
                  command?.phoneNumber
              );
        await _employeesRepository.CreateAsync(employee, command!.password!);
        return Result.Created;
    }

}