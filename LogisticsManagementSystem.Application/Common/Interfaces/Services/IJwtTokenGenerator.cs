using System.Security.Claims;

namespace LogisticsManagementSystem.Application;

public interface IJwtTokenGenerator
{
    string GenerateTokens(IEnumerable<Claim> claims);
}