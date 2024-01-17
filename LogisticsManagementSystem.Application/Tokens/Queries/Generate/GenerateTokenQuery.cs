using ErrorOr;
using LogisticsManagementSystem.Domain;
using MediatR;

namespace LogisticsManagementSystem.Application;

public record GenerateTokenQuery(
    Employee Employee,
    IList<string> Roles) : IRequest<ErrorOr<GenerateTokenResult>>;



