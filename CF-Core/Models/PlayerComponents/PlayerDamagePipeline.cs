namespace CF_Core.Models.PlayerComponents;

public class PlayerDamagePipeline
{
    private DamagePipeline DamagePipeline { get; set; } = new();
    
    
    public static PlayerDamagePipeline Default() {
        return new PlayerDamagePipeline();
    }
    
    public void Add(IDamageModifier modifier)
    {
        DamagePipeline.Add(modifier);
    }
    
    public void Remove(IDamageModifier modifier)
    {
        DamagePipeline.Remove(modifier);
    }

    public DamageContext Process(DamageContext context)
    {
        return DamagePipeline.Process(context);;
    }
}