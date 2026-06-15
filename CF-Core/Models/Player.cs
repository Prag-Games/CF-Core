using CF_Core.Models.PlayerComponents;

namespace CF_Core.Models;

public class Player
{
    private Health Health { get; set; } = Health.Default();
    private PlayerDamagePipeline DamagePipeline { get; set; } = PlayerDamagePipeline.Default();

    
    public void TakeDamage(DamageContext context)
    {
       var resultContext = DamagePipeline.Process(context);

        if (!resultContext.IsCancelled)
            Health.Reduce(resultContext.Amount);
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