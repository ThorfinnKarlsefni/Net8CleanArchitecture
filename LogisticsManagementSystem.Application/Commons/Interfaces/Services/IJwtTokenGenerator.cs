using System.Security.Claims;
using LogisticsManagementSystem.Domain;

namespace LogisticsManagementSystem.Application;

public interface IJwtTokenGenerator
{
    string GenerateTokens(Employee employee, IList<string> roles);
}