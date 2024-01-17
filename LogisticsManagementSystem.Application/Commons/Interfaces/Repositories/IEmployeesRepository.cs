using System.Security.Claims;
using LogisticsManagementSystem.Domain;
using Microsoft.AspNetCore.Identity;

namespace LogisticsManagementSystem.Application;

public interface IEmployeesRepository
{
    Task<Employee?> FindByNameAsync(string userName);
    Task<IdentityResult> CreateAsync(Employee employee, string password);
    Task<bool> EmployeeExistsAsync(string userName);
    Task<bool> CheckPasswordAsync(Employee employee, string password);
    Task<IList<string>> GetRolesAsync(Employee employee);
}

