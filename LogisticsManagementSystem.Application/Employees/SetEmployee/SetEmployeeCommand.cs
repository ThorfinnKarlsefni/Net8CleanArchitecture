using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace LogisticsManagementSystem.Application;

public record SetEmployeeCommand(string userName, string? phoneNumber, string password) : IRequest<ErrorOr<IdentityResult>>;
