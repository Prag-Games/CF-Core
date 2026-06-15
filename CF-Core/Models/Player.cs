using CF_Core.Models.PlayerComponents;

namespace CF_Core.Models;

public class Player
{
    private Health Health { get; set; } = Health.Default();

    public bool IsDead()
    {
        return this.Health.IsZero() || this.Health.IsBelowZero();
    }
}