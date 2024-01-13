using LogisticsManagementSystem.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LogisticsManagementSystem.Infrastructure;

public class AppDbContext : IdentityDbContext<Employee, Role, Guid, EmployeeClaim, EmployeeRole, EmployeeLogin, RoleClaim, EmployeeToken>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}
