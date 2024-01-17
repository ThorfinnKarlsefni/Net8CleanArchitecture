using LogisticsManagementSystem.Application;
using LogisticsManagementSystem.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LogisticsManagementSystem.Infrastructure;

public class EmployeesRepository : IEmployeesRepository
{
    private readonly UserManager<Employee> _employeeManage;

    public EmployeesRepository(UserManager<Employee> employeeManger)
    {
        _employeeManage = employeeManger;
    }

    public async Task<Employee?> FindByNameAsync(string userName)
    {
        return await _employeeManage.FindByNameAsync(userName);
    }
    public async Task<IdentityResult> CreateAsync(Employee employee, string password)
    {
        return await _employeeManage.CreateAsync(employee, password);
    }

    public async Task<bool> EmployeeExistsAsync(string userName)
    {
        return !await _employeeManage.Users.AnyAsync(u => u.UserName == userName);
    }

    public async Task<bool> CheckPasswordAsync(Employee employee, string password)
    {
        return await _employeeManage.CheckPasswordAsync(employee, password);
    }

    public async Task<IList<string>> GetRolesAsync(Employee employee)
    {
        return await _employeeManage.GetRolesAsync(employee);
    }
}

