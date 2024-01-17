using ErrorOr;
using MediatR;

namespace LogisticsManagementSystem.Application;

public class GenerateTokenQueryHandler(IJwtTokenGenerator _jwtTokenGenerator) : IRequestHandler<GenerateTokenQuery, ErrorOr<GenerateTokenResult>>
{
    public Task<ErrorOr<GenerateTokenResult>> Handle(GenerateTokenQuery query, CancellationToken cancellationToken)
    {
        var token = _jwtTokenGenerator.GenerateTokens(
            query.Employee,
            query.Roles
        );

        var result = new GenerateTokenResult(token);

        return Task.FromResult(ErrorOrFactory.From(result));
    }
}
