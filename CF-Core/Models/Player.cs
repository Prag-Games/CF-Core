using CF_Core.Models.PlayerComponents;

namespace CF_Core.Models;

public class Player
{
    private Health Health { get; set; } = Health.Default();
    private PlayerDamagePipeline DamagePipeline { get; set; } = PlayerDamagePipeline.Default();

    
    public void TakeDamage(DamageContext context)
    {
        DamagePipeline.Process(context);

        if (!context.IsCancelled)
            Health.Reduce(context.Amount);
    }
    
    public bool IsDead()
    {
        return this.Health.IsZero() || this.Health.IsBelowZero();
    }

    public bool IsAlive()
    {
        return !this.IsDead();
    }
}