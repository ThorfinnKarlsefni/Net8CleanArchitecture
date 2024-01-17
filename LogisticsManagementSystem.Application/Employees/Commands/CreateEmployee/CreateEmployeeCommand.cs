using ErrorOr;
using MediatR;

namespace LogisticsManagementSystem.Application;

public record CreateEmployeeCommand(string userName, string? phoneNumber, string password, string confirmPassword) : IRequest<ErrorOr<Created>>;
