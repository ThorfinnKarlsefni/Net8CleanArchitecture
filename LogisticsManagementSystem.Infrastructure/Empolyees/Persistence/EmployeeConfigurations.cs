using LogisticsManagementSystem.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LogisticsManagementSystem.Infrastructure;

public class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("Employees");
        builder.Property(u => u.Avatar).HasColumnType("varchar(256)");
        builder.Property(u => u.CreatedAt).HasColumnType("timestamp");
        builder.Property(u => u.DeletedAt).HasColumnType("timestamp");
        builder.Property(u => u.UpdatedAt).HasColumnType("timestamp");
    }
}

public class EmployeeRoleConfig : IEntityTypeConfiguration<EmployeeRole>
{
    public void Configure(EntityTypeBuilder<EmployeeRole> builder)
    {
        builder.ToTable("EmployeeRole");
    }
}

public class EmployeeLoginConfig : IEntityTypeConfiguration<EmployeeLogin>
{
    public void Configure(EntityTypeBuilder<EmployeeLogin> builder)
    {
        builder.ToTable("EmployeeLogin");
    }
}

public class EmployeeClaimConfig : IEntityTypeConfiguration<EmployeeClaim>
{
    public void Configure(EntityTypeBuilder<EmployeeClaim> builder)
    {
        builder.ToTable("EmployeeClaim");
    }
}

public class EmployeeTokenConfig : IEntityTypeConfiguration<EmployeeToken>
{
    public void Configure(EntityTypeBuilder<EmployeeToken> builder)
    {
        builder.ToTable("EmployeeToken");
    }
}
