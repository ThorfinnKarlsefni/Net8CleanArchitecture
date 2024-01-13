using Microsoft.AspNetCore.Identity;

namespace LogisticsManagementSystem.Domain;

public class Role : IdentityRole<Guid>
{
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }

    public Role()
    {
        CreatedAt = DateTime.Now;
        UpdatedAt = CreatedAt;
    }
}
