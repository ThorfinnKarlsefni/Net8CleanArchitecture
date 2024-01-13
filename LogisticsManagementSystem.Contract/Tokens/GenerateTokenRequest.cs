using System.Security.Claims;

namespace LogisticsManagementSystem.Contract;

public record GenerateTokenRequest(List<Claim> Claims);
