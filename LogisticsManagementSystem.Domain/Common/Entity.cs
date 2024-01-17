using System.Net.NetworkInformation;

namespace LogisticsManagementSystem.Domain;

public abstract class Entity
{
    public virtual DateTime CreatedAt { get; init; }
    public virtual DateTime UpdatedAt { get; set; }
    public virtual DateTime DeletedAt { get; set; }

    public Entity()
    {
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = CreatedAt;
    }

    public void SetUpdatedAt()
    {
        this.UpdatedAt = DateTime.UtcNow;
    }

    public void SetDeletedAt()
    {
        this.UpdatedAt = DateTime.UtcNow;
        this.DeletedAt = DateTime.UtcNow;
    }
}
