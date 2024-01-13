using LogisticsManagementSystem.Application;
using LogisticsManagementSystem.Domain;
using Microsoft.AspNetCore.Identity;

namespace LogisticsManagementSystem.Infrastructure;

public class EmployeesRepository : IEmployeesRepository
{
    private readonly UserManager<Employee> _employeeManage;

    public EmployeesRepository(UserManager<Employee> employeeManger)
    {
        _employeeManage = employeeManger;
    }
    public async Task<IdentityResult> CreateAsync(Employee employee, string password)
    {
        return await _employeeManage.CreateAsync(employee, password);
    }
}

