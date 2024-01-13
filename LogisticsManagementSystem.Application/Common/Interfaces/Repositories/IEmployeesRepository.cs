using System.Security.Claims;
using LogisticsManagementSystem.Domain;
using Microsoft.AspNetCore.Identity;

namespace LogisticsManagementSystem.Application;

public interface IEmployeesRepository
{
    Task<IdentityResult> CreateAsync(Employee employee, string password);
}

