namespace CF_Core.Models;

public class DamageContext
{
    public int Amount  { get; set; }
    public DamageType DamageType { get; set; }
    public bool IsCancelled { get; set; }

    private DamageContext()
    {
    }

    public DamageContext(int amount, DamageType damageType)
    {
        Amount = amount;
        DamageType = damageType;
    }
}