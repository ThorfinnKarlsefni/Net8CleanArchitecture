using System.Security.Principal;
using Microsoft.AspNetCore.Identity;

namespace LogisticsManagementSystem.Domain;

public class Employee : IdentityUser<Guid>
{
    public string? Avatar { get; set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }
    public DateTime? DeletedAt { get; private set; }

    public Employee(string userName, string? phoneNumber) : base(userName)
    {
        Id = Guid.NewGuid();
        PhoneNumber = phoneNumber;
        CreatedAt = DateTime.Now;
        UpdatedAt = CreatedAt;
    }

    public void SoftDelete()
    {
        DeletedAt = DateTime.Now;
    }
}
