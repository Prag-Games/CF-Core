namespace CF_Core.Models;

public class DamagePipeline
{
    private readonly List<IDamageModifier> _modifiers = [];

    public void Add(IDamageModifier modifier)
    {
        _modifiers.Add(modifier);
    }
    
    public void Remove(IDamageModifier modifier)
    {
        _modifiers.Remove(modifier);
    }

    public DamageContext Process(DamageContext context)
    {
        foreach (var modifier in _modifiers)
        {
            modifier.Modify(context);
            if (context.IsCancelled) return context;
        }

        return context;
    }
}