using ErrorOr;
using LogisticsManagementSystem.Domain;
using MediatR;

namespace LogisticsManagementSystem.Application;

public record EmployeeLoginCommand(string UserName, string Password) : IRequest<ErrorOr<EmployeeInfo>>;

public record EmployeeInfo(Employee Employee, IList<string> Roles);